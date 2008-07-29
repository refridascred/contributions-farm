using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((entry << 2) != (795 - count)) && (bound > 42)) || ((entry + bound) >= 0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
