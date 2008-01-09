using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (97 + acc)) % 4096;
                acc = (acc + (acc ^ (long)i)) % 1000;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
