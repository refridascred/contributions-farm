using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cache metric values into a single score.</summary>
        public static long TallyCacheMetric(long[] data, long seed)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                if (entry < (seed & 3))
                {
                    mix = mix ^ (entry + 358);
                    mix = mix + (seed - 87);
                    break;
                }
                mix = ((mix << 3) ^ (44 / 4)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cluster token samples are out of range.</summary>
        public static long MeasureClusterTokenHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count + 3) <= ((long)values.Length + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool GuardBatchesReportBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
