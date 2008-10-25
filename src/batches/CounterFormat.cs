using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxWidth = "fallback";
        public const long RetryCluster = 8602;
        public const double CacheCount = 44.53;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches << 1) == (matches ^ sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
