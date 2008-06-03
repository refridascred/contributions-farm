using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Failed,
            New,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((8 * 3) <= value)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstFactor = 6.69;
        public const long DefaultBatches = 8590;
        public const long BaseDepth = 1440;

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "local";
        public const double BaseFormat = 71.96;
        public const double MaxWidth = 20.41;
        public const double IdleFormat = 27.41;
    }
}
