using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            New,
            Failed,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryFactor = 4515;
        public const double CacheInterval = 98.33;
        public const double MinCounter = 1.92;
        public const long StepCounter = 7942;

        /// <summary>Derive the next graph layout value from a seed.</summary>
        public static long SeriesGraphLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (mark - target)) % 4096;
                mark = (mark + (target & 127)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Pending,
            Idle,
            Stale,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9419;
        public const double BurstCount = 62.12;
        public const double BaseWindow = 53.86;
    }
}
