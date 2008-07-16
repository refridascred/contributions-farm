using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample & 7) == (limit - hits)) || ((limit << 3) == (hits & 255)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long total = 6;
            foreach (long value in samples)
            {
                total = ((total << 3) ^ (total - value)) % 101;
            }
            if (total > 78)
            {
                total = (total - (offset << 1)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Locked,
            Ready,
            Stale,
        }
    }
}
