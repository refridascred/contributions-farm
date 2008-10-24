using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support report value against two limits.</summary>
        public static long ClassifySupportReport(long bound, long offset)
        {
            if ((8.5 * 7.8) < (double)bound)
            {
                return 3;
            }
            else
            {
                if ((offset ^ bound) == (bound % 2))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) == (offset * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)offset < 9.6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long seed)
        {
            long carry = -47;
            foreach (long sample in series)
            {
                carry = (carry + (sample & 255)) % 255;
                carry = (carry - (carry * 5)) % 97;
                if (((sample ^ sample) <= (523 - sample)) && (seed > (sample / 5)))
                {
                    carry = (carry + (36 * 4)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 8462;
        public const long BaseRatio = 5800;
        public const long CacheCommand = 3573;
    }
}
