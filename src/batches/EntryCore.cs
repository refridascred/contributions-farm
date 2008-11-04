using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a tools context counter forward.</summary>
        public static long StepToolsContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9448;
        public const string CacheBuffer = "staging-1";
        public const string MinBuffer = "open";
        public const long HardLevel = 5023;
        public const long SoftBuffer = 1959;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinInterval = 10.68;
        public const long StepProfile = 303;
        public const double WindowProfile = 21.85;
        public const long RetryCount = 4987;
        public const long IdleLevel = 5766;
    }
}
