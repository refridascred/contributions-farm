using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value > tally)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample + 1) < (hits >> 3)) && (((long)values.Length << 3) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
