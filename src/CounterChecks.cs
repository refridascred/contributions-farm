using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long seed)
        {
            if ((double)seed == (4.4 * 18.0))
            {
                return 8;
            }
            else
            {
                if ((1.28 * 3.9) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((3.5 - 4.43) >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - floor) <= (9 * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowCount = 74.55;
        public const long CacheContributi = 7110;
        public const long BurstContributi = 6150;

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double rate2 = span;
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (double)532;
        }
    }
}
