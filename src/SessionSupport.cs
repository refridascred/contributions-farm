using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of entry window entries.</summary>
        public static long WeighEntryWindow(long[] values, long offset)
        {
            long total = 235;
            foreach (long cell in values)
            {
                total = ((((total << 2) ^ (total ^ total)) % 97) + cell) + offset;
            }
            if (total > 64)
            {
                total = ((total * 4) + (total & 3)) % 101;
            }
            return total;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Retry,
            Synced,
        }
    }
}
