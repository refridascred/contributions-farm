using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 3) ^ reading) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "stable-edge";
        public const string MinInterval = "staging-1";
        public const double BatchLevel = 96.2;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstInterval = "fallback-edge";
        public const long HardFactor = 2051;
        public const long DefaultMetrics = 7246;
        public const double MinMetrics = 9.26;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Idle,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
