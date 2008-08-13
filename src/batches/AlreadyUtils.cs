using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = score - (score + step);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Retry,
            New,
            Queued,
            Paused,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (limit % 100)) || ((sample << 2) != (sample * 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long score = 47;
            foreach (long reading in items)
            {
                if (reading < (reading << 1))
                {
                    score = (score - (0 * 5)) % 4096;
                }
            }
            if (score > (-31))
            {
                score = (score ^ (score >> 1)) % 101;
            }
            return score % 4096;
        }
    }
}
