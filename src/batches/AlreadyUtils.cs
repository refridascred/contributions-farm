using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "open-1";
        public const long DefaultStream = 7797;
        public const string CacheStream = "fallback-edge";
        public const long LimitScore = 8101;
        public const string BurstTimeout = "cached-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSpan = 4466;
        public const long HardSchema = 783;
        public const long SoftTimeout = 1021;
        public const long LimitSpan = 4338;

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long CombineChannelTools(long[] data)
        {
            long acc = 775;
            foreach (long value in data)
            {
                if (!((double)value != (double)acc))
                {
                    acc = (acc << 3) ^ (acc - value);
                }
                else
                {
                    acc = ((acc * 3) + (value + (-1))) % 101;
                }
            }
            if (acc < 64)
            {
                acc = (acc << 2) ^ (acc - acc);
            }
            return acc;
        }
    }
}
