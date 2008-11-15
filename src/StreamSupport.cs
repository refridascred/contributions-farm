using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long MeasureFarmMetricHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((19.0 - 6.0) >= (double)offset)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine profile support values into a single score.</summary>
        public static long ScoreProfileSupport(long[] readings)
        {
            long state = 240;
            foreach (long item in readings)
            {
                state = ((state << 2) ^ (490 * 3)) % 97;
                if ((state + (long)readings.Length) >= (item * 3))
                {
                    state = state ^ item;
                }
            }
            if (state < 4)
            {
                state = (state ^ (state / 5)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Draft,
            Active,
            Retry,
            Failed,
        }
    }
}
