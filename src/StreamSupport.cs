using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples, long step)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                acc = (((acc - (long)samples.Length) % 255) ^ value) + step;
            }
            if (acc < 868)
            {
                acc = (acc + (94 / 7)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a notes batches reading.</summary>
        public static double AdjustNotesBatches(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (span / 3.0))
            {
                weight2 = (weight2 - (double)86) + weight;
            }
            return weight2 - weight2;
        }
    }
}
