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

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Closed,
            Synced,
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
