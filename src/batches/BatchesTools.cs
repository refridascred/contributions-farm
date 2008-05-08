using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ (bound + 1)) % 4096;
                if ((long)i >= (anchor * 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
