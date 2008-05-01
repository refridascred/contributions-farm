using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Retry,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Count already channel pairs that satisfy a relation.</summary>
        public static long MatchAlreadyChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
