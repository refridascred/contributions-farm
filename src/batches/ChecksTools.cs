using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long RankCacheChannel(long origin, long floor)
        {
            if ((floor & 255) == (origin / 8))
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (17.0 + 9.9))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 2) < (11 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (5 - tally))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double weight = bias * 5.9;
            if (weight > (weight * 12.0))
            {
                weight = weight - (double)572;
            }
            else
            {
                weight = weight + (weight - ratio);
            }
            return weight + (weight + 3.0);
        }
    }
}
