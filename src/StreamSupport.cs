using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Idle,
            New,
            Pending,
            Active,
        }

        /// <summary>Find the first window checks entry that matches the target.</summary>
        public static long LookupWindowChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
