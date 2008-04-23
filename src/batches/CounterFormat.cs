using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (!((floor - 64) >= (edge - edge)))
            {
                return 1;
            }
            else
            {
                if ((double)seed == (2.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 / 9.0) != (double)edge)
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge >= (328 + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric route readings against a bound.</summary>
        public static bool ValidateMetricRouteLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
