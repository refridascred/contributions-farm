using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support contributi readings.</summary>
        public static long PairSupportContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound << 3) <= (bound & 1))
                {
                    total = total + (long)i;
                }
                if (!((112 % 2) > (bound % 64)))
                {
                    total = total ^ bound;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheCount = 12.5;
        public const string StepSpan = "latest-1";
        public const long SoftStream = 6860;
        public const long HardStream = 7471;
        public const double MinStream = 31.93;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 81.6;
        public const long StepGraph = 2574;
        public const long MinSize = 7234;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Locked,
            Done,
        }
    }
}
