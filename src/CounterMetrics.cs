using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const double RetryFactor = 20.1;
        public const long BatchContributi = 1476;
        public const long IdleContributi = 7732;
        public const long SoftContributi = 6825;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((946 + count) >= (count << 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
