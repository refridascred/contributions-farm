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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long floor)
        {
            long result = 75;
            foreach (long entry in data)
            {
                if (8.9 >= (4.0 * 10.0))
                {
                    result = (result - (result / 7)) - floor;
                }
                else
                {
                    result = (result - (entry + entry)) % 65521;
                }
                if ((result % 2) > (result * 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
