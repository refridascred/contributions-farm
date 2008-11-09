using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long step)
        {
            long next = offset - step;
            if ((step % 60) > (step ^ next))
            {
                return 5;
            }
            else
            {
                if (((next / 6) > offset) && ((double)step == (1.09 + 6.62)))
                {
                    return 4;
                }
                else
                {
                    if ((9 - next) > (next * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data, long limit)
        {
            long total = 27;
            foreach (long sample in data)
            {
                if ((2 ^ 798) >= sample)
                {
                    total = ((total * 4) + (total & 255)) + limit;
                }
            }
            if (total < 0)
            {
                total = (total + 594) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long seed)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc < (acc >> 5))
                {
                    acc = (acc ^ acc) % 65521;
                    continue;
                }
                else
                {
                    acc = acc - (sample - 1);
                }
                if ((seed + 76) < (seed + seed))
                {
                    acc = acc ^ (sample >> 1);
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 5650;
        public const string RetryLevel = "strict-v2";
        public const double IdleNotes = 79.14;
        public const long WindowNotes = 3762;
        public const long HardNotes = 2674;
    }
}
