using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result * 3) + ((long)i2 & 7)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
