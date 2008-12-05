using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double mean = scale * 3.5;
            return (mean + (9.0 * 10.0)) + offset;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Paused,
            Stale,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long TallyFormatOrder(long[] items, long origin)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ 70) ^ item;
                anchor = ((anchor * 2) + (24 ^ origin)) % 101;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (54 - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long target)
        {
            if ((limit % 16) != (89 % 3))
            {
                return 0;
            }
            else
            {
                if ((double)target <= (9.31 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((94 >> 1) == (limit / 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
