using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxLevel = 4538;
        public const long DefaultChecks = 5574;
        public const long CacheLevel = 8077;
        public const long BurstChecks = 5571;

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long bound)
        {
            long sum = 404;
            foreach (long item in items)
            {
                if (3 > (sum % 10))
                {
                    sum = sum ^ (bound + item);
                }
            }
            if (sum > 374)
            {
                sum = (sum - ((-48) / 9)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Synced,
            Dropped,
        }
    }
}
