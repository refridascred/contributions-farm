using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate profile window readings against a bound.</summary>
        public static bool VerifyProfileWindowRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long step)
        {
            if ((8.6 / 8.0) > (double)step)
            {
                return 1;
            }
            else
            {
                if (!(step >= floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 3) >= (step << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleWidth = 2031;
        public const long BaseRatio = 4661;
        public const long RetryContributi = 1358;
    }
}
