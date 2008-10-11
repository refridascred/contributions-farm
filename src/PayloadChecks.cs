using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftFactor = 5486;
        public const long BurstGraph = 3099;
        public const long BatchGraph = 5408;
        public const string RetryBudget = "local-v2";
        public const long IdleCount = 4683;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 334;
        public const string DefaultCache = "latest-1";
        public const double SoftCache = 97.07;
        public const long BaseTimeout = 9021;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long target)
        {
            long total = 43;
            foreach (long cell in levels)
            {
                if (!(total < (cell / 7)))
                {
                    total = ((total * 4) + (total * 3)) % 101;
                }
                if ((3.1 - 6.7) != (double)target)
                {
                    total = (total + (937 & 63)) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            if (total > 112)
            {
                total = (total ^ (2 - target)) % 101;
            }
            return total % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5413;
        public const long CacheSize = 9942;
        public const long BatchBudget = 1934;
        public const long MinAccount = 6727;
        public const string BurstCount = "staging-1";
    }
}
