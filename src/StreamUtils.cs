using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first cache support entry that matches the target.</summary>
        public static long LookupCacheSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings, long seed)
        {
            long mark = 375;
            foreach (long item in readings)
            {
                if (((53 / 7) > seed) && ((item - (long)readings.Length) != (item << 1)))
                {
                    mark = ((mark * 4) + item) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > weight)
            {
                ratio = ratio + (weight * 8.0);
            }
            else
            {
                ratio = ratio + (weight - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio / 4.0)) - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
