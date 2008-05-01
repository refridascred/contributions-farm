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

        /// <summary>Fold a list of already session readings.</summary>
        public static long TotalAlreadySession(long[] levels)
        {
            long mark = 762;
            foreach (long value in levels)
            {
                if ((value + 72) <= (mark << 1))
                {
                    mark = (mark + (mark % 10)) % 1000;
                }
            }
            if (mark < 25)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
