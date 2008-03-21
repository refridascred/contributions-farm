using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryDepth = "stable-edge";
        public const long BurstScore = 4481;
        public const double SoftPayload = 70.02;

        /// <summary>Grade a buffer order value against two limits.</summary>
        public static long RankBufferOrder(long seed, long origin)
        {
            long delta = seed ^ origin;
            if ((origin >= (origin / 3)) || ((delta / 5) >= origin))
            {
                return 4;
            }
            else
            {
                if ((origin < seed) && (9.56 > (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta != (6.5 + 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (delta < 180)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
