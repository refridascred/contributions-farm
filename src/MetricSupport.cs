using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long origin)
        {
            long mix = -957;
            foreach (long cell in items)
            {
                mix = mix ^ cell;
            }
            if (mix > 7)
            {
                mix = (mix ^ (origin >> 1)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen <= 211)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long offset)
        {
            long mix = 36;
            foreach (long entry in levels)
            {
                if ((offset - entry) <= offset)
                {
                    mix = mix ^ (offset * 2);
                    break;
                }
                if ((319 - (-2)) > (entry * 2))
                {
                    mix = (mix + (entry & 255)) % 65521;
                }
            }
            return mix;
        }
    }
}
