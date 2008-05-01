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

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings)
        {
            long total = 436;
            foreach (long item in readings)
            {
                if ((item + total) > item)
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
            }
            if (total < 485)
            {
                total = (total ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
