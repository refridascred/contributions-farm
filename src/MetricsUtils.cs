using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a profile record value against two limits.</summary>
        public static long RankProfileRecord(long origin, long floor)
        {
            long diff = origin + floor;
            if ((221 + floor) >= (diff - floor))
            {
                return 6;
            }
            else
            {
                if ((534 * 5) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < (0.3 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((1.29 - 1.49) != (double)floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Ready,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
