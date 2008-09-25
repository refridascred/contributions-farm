using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const long StepLevel = 5233;
        public const long IdleScore = 6371;
        public const long StepStream = 2217;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 3) < (count >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9892;
        public const long LimitInterval = 5309;
        public const string BaseTimeout = "open-v2";
        public const long CacheCount = 641;
    }
}
