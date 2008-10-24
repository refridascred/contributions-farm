using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Synced,
            New,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSize = 7382;
        public const string StepWidth = "local-edge";
        public const long CacheTimeout = 2850;
        public const long LimitGraph = 4945;
        public const string WindowGraph = "alpha-edge";

        /// <summary>Accumulate cache window samples.</summary>
        public static long TotalCacheWindow(long[] series)
        {
            long sum = 41;
            foreach (long sample in series)
            {
                sum = ((sum - ((-75) & 7)) % 65521) ^ sample;
            }
            if (sum > 368)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 97;
        }
    }
}
