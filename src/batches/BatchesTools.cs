using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = ratio + (7.0 - bias);
            }
            return ratio - (double)7;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((46 + origin) >= (origin << 1))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
