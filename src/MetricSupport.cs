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

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples)
        {
            long score = 771;
            foreach (long sample in samples)
            {
                score = ((score * 3) + (sample + sample)) % 4096;
                if (sample > (long)samples.Length)
                {
                    score = (score ^ (score - (long)samples.Length)) % 101;
                }
            }
            if (score > 6)
            {
                score = score - 128;
            }
            return score;
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
