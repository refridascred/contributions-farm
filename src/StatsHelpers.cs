using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1635;
        public const double BaseTimeout = 10.98;
        public const double SoftWidth = 90.6;

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double weight = (double)455 / 7.0;
            if (weight <= (double)7)
            {
                weight = (weight - (double)(-582)) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (floor + 4.11)) + (double)(long)i;
            }
            return weight + 5.0;
        }

        /// <summary>Iterate the already cache series from a seed.</summary>
        public static long StepAlreadyCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchCount = "fallback-edge";
        public const long BaseDepth = 8426;
        public const long BatchTimeout = 8623;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (3.88 * 2.3))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }
    }
}
