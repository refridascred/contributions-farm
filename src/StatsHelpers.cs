using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((bound % 24) <= (value % 64))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9929;
        public const double CacheRatio = 24.7;
        public const long BaseDepth = 9031;
        public const long RetryEntry = 9830;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2187;
        public const long RetryGraph = 150;
        public const double BatchGraph = 76.91;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Failed,
            Retry,
            Closed,
            Done,
        }
    }
}
