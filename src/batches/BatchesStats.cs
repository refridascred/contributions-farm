using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(seen > (seed + seen)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
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
