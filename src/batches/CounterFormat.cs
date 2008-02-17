using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "latest-edge";
        public const double MinStats = 30.54;
        public const long BurstStats = 6842;
        public const string BaseWidth = "cached-1";

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length > 9.91)
                {
                    count = ((count + 2) + reading) - offset;
                }
            }
            return count;
        }
    }
}
