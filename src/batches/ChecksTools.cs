using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long result = 169;
            foreach (long reading in levels)
            {
                if (seed <= result)
                {
                    result = (result << 3) ^ (seed - reading);
                }
                if ((result * 3) <= (seed - reading))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (lane > floor)
            {
                return 0;
            }
            else
            {
                if ((double)bound == (2.89 + 4.3))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 7) < (floor ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < (lane % 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double ratio, double floor)
        {
            double mean = floor;
            if (mean > mean)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)43) + (double)(long)i;
            }
            return mean + (ratio - mean);
        }
    }
}
