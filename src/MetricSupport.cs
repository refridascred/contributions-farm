using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                double ratio = (1.91 + 5.0) + (18.0 * 14.0);
                double bias = ratio;
                ratio = ratio - bias;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
