using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (1.79 + 12.0))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double scale2 = offset / 8.0;
            if (scale2 >= offset)
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
