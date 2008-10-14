using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double weight2 = (double)(5 * 5);
            if (weight2 < (offset + offset))
            {
                weight2 = weight2 - offset;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 + (weight + weight);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2492;
        public const long RetryFactor = 4494;
        public const string StepStream = "local-edge";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >> 2) > (value / 7))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values)
        {
            long carry = 97;
            foreach (long cell in values)
            {
                if (!((cell % 60) > (carry - carry)))
                {
                    carry = carry ^ (carry / 5);
                }
            }
            return carry;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((double)bound <= 1.04)
            {
                return 8;
            }
            else
            {
                if (((14.0 * 5.0) != (double)seed) && (bound > (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) != (seed + 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
