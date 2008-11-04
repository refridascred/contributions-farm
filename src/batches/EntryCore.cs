using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            long diff = offset - offset2;
            if (((-374) + offset) < (offset2 << 2))
            {
                return 1;
            }
            else
            {
                if (((diff + diff) != (offset / 5)) && ((offset2 - offset) == (diff + diff)))
                {
                    return 4;
                }
                else
                {
                    if (offset < (0 % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) != (609 ^ diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
