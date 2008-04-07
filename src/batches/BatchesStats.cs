using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "cached-v2";
        public const long HardLevel = 3800;
        public const long CacheBudget = 3719;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if ((double)origin != (13.0 * 2.0))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (18.0 + 6.85))
                {
                    return 8;
                }
                else
                {
                    if ((origin << 1) <= (bound - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public double Total { get; set; }
        }
    }
}
