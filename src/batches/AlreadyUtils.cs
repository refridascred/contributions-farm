using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 1836;
        public const string CacheTimeout = "stable";
        public const long BaseFormat = 883;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Draft,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinLevel = "cached";
        public const long RetryRatio = 463;
        public const string BurstDepth = "legacy-v2";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((7.0 - 18.0) <= (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
