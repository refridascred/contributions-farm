using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCount = 70.28;
        public const long CacheSpan = 1944;
        public const long IdleScore = 6951;
        public const long IdleSize = 8430;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = floor / 9.0;
            if (drift < ratio)
            {
                drift = drift + drift;
            }
            return drift - floor;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Closed,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 9160;
        public const string MinCache = "open-v2";
        public const long BatchCache = 9751;
        public const double MaxBudget = 71.95;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
