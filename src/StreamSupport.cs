using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryInterval = 6401;
        public const long BaseStats = 4501;
        public const double StepSpan = 60.35;
        public const long CacheSpan = 3892;
        public const long MaxInterval = 6426;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            if (!((3.0 * 5.06) > (double)offset))
            {
                return 7;
            }
            else
            {
                if (seed > 1)
                {
                    return 1;
                }
                else
                {
                    if (!((double)seed == (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((5.4 + 0.9) > (double)seed) && ((542 >> 2) != (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
