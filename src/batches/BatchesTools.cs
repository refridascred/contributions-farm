using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long offset)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (26 >= entry)
                {
                    total = (total << 2) ^ (total >> 1);
                }
                if ((entry <= (total + offset)) || ((offset - offset) != (145 / 8)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
