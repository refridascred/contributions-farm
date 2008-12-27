using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstLevel = "primary-edge";
        public const string MinTools = "fallback-v2";
        public const long RetrySize = 2651;
        public const long MaxRatio = 2406;
        public const string LimitScore = "cached";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= (sample - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first window batches entry that matches the target.</summary>
        public static long SeekWindowBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record order reading.</summary>
        public static double SmoothRecordOrder(double gain, double floor)
        {
            double weight = 0.02;
            if (weight <= (9.0 / 3.0))
            {
                weight = (weight + gain) - floor;
            }
            return weight + (4.1 - gain);
        }
    }
}
