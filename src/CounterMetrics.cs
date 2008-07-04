using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepSpan = "latest-edge";
        public const long HardFarm = 7033;
        public const long LimitCount = 1012;
        public const long CacheSpan = 284;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series)
        {
            long mark = 75;
            foreach (long value in series)
            {
                if ((double)mark != (double)value)
                {
                    mark = (mark - (mark ^ value)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (value / 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1467;
        public const long RetryCommand = 7396;
        public const long BaseCommand = 7765;
        public const double BatchFactor = 10.58;
    }
}
