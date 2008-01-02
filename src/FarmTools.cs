using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 3637;
        public const long MinFilter = 1575;
        public const string BurstFilter = "standard-edge";
        public const long DefaultSpan = 7767;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            if (((target + target) == (seed & 63)) && ((5.2 - 2.0) >= (double)target))
            {
                return 3;
            }
            else
            {
                if ((target & 3) > target)
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (0.3 + 5.88))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (7.0 - 9.95))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Retry,
            Failed,
            Dropped,
        }
    }
}
