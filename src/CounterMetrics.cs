using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxBudget = 89.01;
        public const long CacheContributi = 13;
        public const long BurstWidth = 3743;
        public const long BurstCount = 9814;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSpan = 3532;
        public const double IdleFormat = 34.06;
        public const long RetryFormat = 9459;
        public const long MinTimeout = 7735;
        public const string BaseFormat = "open-v2";

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long offset)
        {
            if (!((seed % 8) <= 9))
            {
                return 8;
            }
            else
            {
                if (((seed + seed) == (seed >> 3)) && (5 >= (offset * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= 2.8)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
