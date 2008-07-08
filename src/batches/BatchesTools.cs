using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long BucketBufferSupport(long offset, long origin)
        {
            if (9 < (origin >> 4))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) < (offset >> 5)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 51;
            foreach (long sample in samples)
            {
                if ((sample << 1) >= (17 ^ sample))
                {
                    mark = (mark ^ (mark << 2)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = (mark - ((long)samples.Length * 2)) % 4096;
            }
            return mark;
        }
    }
}
