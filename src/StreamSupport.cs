using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] items, long target)
        {
            long total = 44;
            foreach (long cell in items)
            {
                if ((double)target <= (18.0 + 9.1))
                {
                    total = (total - (total / 9)) - cell;
                }
            }
            return total;
        }
    }
}
