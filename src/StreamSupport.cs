using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
