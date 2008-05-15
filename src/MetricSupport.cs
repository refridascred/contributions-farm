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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7944;
        public const double SoftOrder = 49.33;
        public const long IdleOrder = 9098;
    }
}
