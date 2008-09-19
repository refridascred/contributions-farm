using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long seed, long bound)
        {
            if (((seed - 5) == (bound & 1)) || ((double)bound >= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) <= (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (7.6 - 3.91))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.6 / 8.0) > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 2106;
        public const long MinAlready = 1942;
        public const long MaxBudget = 813;
        public const long RetryWidth = 5522;
        public const long IdleRatio = 3888;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Synced,
            Closed,
            Ready,
            Queued,
        }
    }
}
