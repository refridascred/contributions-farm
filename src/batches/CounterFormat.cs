using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long CountContributiEntryMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)(long)data.Length >= (17.0 - 4.76)))
                {
                    tally = ((tally + 2) - cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2621;
        public const long BurstCount = 1751;
        public const string DefaultCount = "standard-edge";
        public const long RetryCache = 7177;
    }
}
