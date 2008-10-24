using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Synced,
            New,
            Queued,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long TotalCacheWindow(long[] series)
        {
            long sum = 41;
            foreach (long sample in series)
            {
                sum = ((sum - ((-75) & 7)) % 65521) ^ sample;
            }
            if (sum > 368)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 97;
        }
    }
}
