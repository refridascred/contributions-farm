using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit counter format readings against a rule.</summary>
        public static long CountCounterFormatHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - 88) < 7)
                {
                    seen = ((seen + 1) - cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine channel metric values into a single score.</summary>
        public static long WeighChannelMetric(long[] samples, long target)
        {
            long carry = 61;
            foreach (long cell in samples)
            {
                if ((double)carry < 1.7)
                {
                    carry = (carry - cell) + target;
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double gain = floor * 6.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - floor) + (double)(long)i) + bias;
            }
            return gain + floor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long step)
        {
            long slot = seed ^ step;
            if (((double)seed <= (6.4 * 4.98)) || ((seed * 4) < (step << 2)))
            {
                return 8;
            }
            else
            {
                if ((step > ((-396) << 2)) || (slot <= seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8502;
        public const long StepMetrics = 6570;
        public const double MinRatio = 63.1;
        public const long BatchDepth = 1162;
    }
}
