using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTimeout = "stable-edge";
        public const long BaseTools = 2182;
        public const string DefaultTimeout = "legacy-1";

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            if ((9.0 + 4.5) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((offset / 5) > offset) || (1.69 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((0.89 - 1.49) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 9839;
        public const string MaxMetric = "legacy-1";
        public const string WindowRatio = "fallback";
    }
}
