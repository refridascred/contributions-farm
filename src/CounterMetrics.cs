using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels, long step)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (((item % 97) < (mix + item)) && (8.0 > (double)step))
                {
                    mix = ((mix * 5) + step) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long AuditSupportMetricOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((step + matches) >= (1 / 6))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long RankFilterTools(long floor, long offset)
        {
            if (floor >= 84)
            {
                return 3;
            }
            else
            {
                if ((double)offset > 9.1)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
