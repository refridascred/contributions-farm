using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of buffer editor entries.</summary>
        public static long FoldBufferEditor(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = acc + (acc + acc);
                if (((14.0 / 4.0) < (double)reading) && ((reading << 1) != (acc >> 5)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
