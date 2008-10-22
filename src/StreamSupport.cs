using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the token notes entries that pass the check.</summary>
        public static long TallyTokenNotesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + seen) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 1397;
        public const long BatchSpan = 3832;
        public const long IdleChannel = 8473;
        public const long MinChannel = 9234;
        public const long BaseChannel = 8775;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
