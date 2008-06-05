using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (floor / 3.0))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)25) - (double)(long)i;
            }
            return bias2 + (bias2 + bias2);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 31) > (seen / 5))
                {
                    seen = ((seen + 1) - item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "latest-edge";
        public const long StepAlready = 2163;
        public const long BaseAlready = 2034;
        public const double HardAlready = 64.37;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long target)
        {
            if (((origin - origin) == (0 / 5)) || ((target / 9) == (target + 248)))
            {
                return 6;
            }
            else
            {
                if (((63 >> 5) < origin) && ((origin * 3) <= (origin - target)))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 3) <= 994)
                    {
                        return 0;
                    }
                    else
                    {
                        if (target > (target - origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
