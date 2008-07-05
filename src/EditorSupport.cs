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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (origin + 6)) % 4096;
                if ((total * 5) < (long)i)
                {
                    total = total ^ origin;
                    total = (total * 4) + (total << 2);
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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
