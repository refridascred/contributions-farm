using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Closed,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Derive the next layout filter value from a seed.</summary>
        public static long IterateLayoutFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                double load = 6.54;
                double ratio = (load + load) / 7.0;
                if ((double)(long)i < ratio)
                {
                    acc = (acc ^ 42) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
