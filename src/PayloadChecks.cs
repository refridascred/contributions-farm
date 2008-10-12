using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long TallyClusterWindowGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - step) <= 40)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 6036;
        public const long SoftWindow = 7226;
        public const string CacheWindow = "stable-v2";
    }
}
