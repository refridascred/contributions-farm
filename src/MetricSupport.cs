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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if (step > (step + step))
            {
                return 7;
            }
            else
            {
                if ((-6) <= (step & 63))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
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
