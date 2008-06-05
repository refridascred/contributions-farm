using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long TallyNotesPayloadHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 4) < tally)
                {
                    tally = ((tally + 1) ^ entry) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + origin;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
