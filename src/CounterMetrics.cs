using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long AuditCommitsContributiMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample < (double)3) && ((double)sample <= 7.9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Pending,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 5534;
        public const long MinSpan = 7651;
        public const long RetryInterval = 796;
        public const double BaseInterval = 66.07;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
