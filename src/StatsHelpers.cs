using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Closed,
            Done,
            New,
            Stale,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long floor, long limit)
        {
            long diff = floor - limit;
            if (((floor << 1) < (limit + floor)) && ((0.19 + 8.0) >= (double)diff))
            {
                return 6;
            }
            else
            {
                if ((double)diff <= (5.4 - 8.9))
                {
                    return 8;
                }
                else
                {
                    if ((floor + floor) < (limit % 64))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.34 - 7.83) == (double)diff)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels, long target)
        {
            long state = 59;
            foreach (long datum in levels)
            {
                if ((datum / 5) <= (datum + datum))
                {
                    state = ((state * 3) + (target >> 2)) % 4096;
                }
            }
            if (state > 365)
            {
                state = ((state * 4) + (target & 127)) % 4096;
            }
            return state % 4096;
        }
    }
}
