using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long sum = -57;
            foreach (long cell in items)
            {
                sum = (sum * 2) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Paused,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6 / 2) == (datum << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 29.43;
        public const long HardRecord = 9645;
        public const double WindowWidth = 91.65;
    }
}
