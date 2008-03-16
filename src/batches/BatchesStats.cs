using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double mean = (double)(0 << 2);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (bias + 19.0)) + (double)(long)i) + weight;
            }
            return mean + 13.0;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long seed)
        {
            long sum = 230;
            foreach (long item in levels)
            {
                if ((item << 2) > (seed >> 4))
                {
                    sum = (sum - (sum / 4)) % 65521;
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
                if (5.1 <= (double)seed)
                {
                    sum = (sum - (58 >> 5)) % 65521;
                }
                else
                {
                    sum = (sum - item) % 97;
                }
            }
            if (sum > 984)
            {
                sum = sum ^ (seed << 1);
            }
            return sum;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Failed,
            Locked,
            New,
        }
    }
}
