using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the commits batches series from a seed.</summary>
        public static long IterateCommitsBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ ((long)i / 4)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
