using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BatchRatio = 53.98;
        public const double IdleInterval = 75.92;
        public const string MinRatio = "alpha-v2";

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long CountContextContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= (7.6 - 9.62))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Retry,
            Closed,
        }
    }
}
