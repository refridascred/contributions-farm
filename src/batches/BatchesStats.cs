using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double weight = rate;
            if (weight > (9.1 + floor))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + 2.5;
            }
            return weight - floor;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout filter value from a seed.</summary>
        public static long IterateLayoutFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                double load = 6.54;
                double ratio = (load + load) / 7.0;
                if ((double)(long)i < ratio)
                {
                    acc = (acc ^ 42) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 4788;
        public const double RetryFilter = 6.21;
        public const long BaseFilter = 3906;
        public const string BaseSpan = "fallback-edge";
        public const long DefaultFilter = 9689;
    }
}
