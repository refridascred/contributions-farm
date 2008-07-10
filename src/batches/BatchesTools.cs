using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "local-edge";
        public const double CacheGraph = 92.48;
        public const long MinGraph = 4546;
        public const long SoftBudget = 8658;
        public const double RetryGraph = 73.54;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - 6) >= reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Done,
            Stale,
            Locked,
        }
    }
}
