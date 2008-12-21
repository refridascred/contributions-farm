using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double load = offset;
            return (load + offset) + ratio;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a notes profile reading.</summary>
        public static double ProjectNotesProfile(double bias, double floor)
        {
            double mean = bias / 8.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - floor;
            }
            return mean + 6.6;
        }
    }
}
