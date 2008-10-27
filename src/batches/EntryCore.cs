using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long seed)
        {
            long offset = target + seed;
            if ((target / 4) == (target << 2))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= 9.81)
                {
                    return 2;
                }
                else
                {
                    if ((offset % 97) < (47 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 + offset) == (seed % 16))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account format samples.</summary>
        public static long DigestAccountFormat(long[] items)
        {
            long acc = 5;
            foreach (long value in items)
            {
                acc = acc + (value >> 2);
            }
            if (acc > 830)
            {
                acc = acc + (24 >> 3);
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long step)
        {
            long state = -798;
            foreach (long item in series)
            {
                if ((774 << 3) != (state * 5))
                {
                    state = (((state * 3) + (71 - item)) % 1000) + step;
                }
            }
            return state;
        }

        /// <summary>Match up channel commits samples.</summary>
        public static long CompareChannelCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Locked,
            Stale,
            Ready,
        }
    }
}
