using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long offset)
        {
            long mark = 31;
            foreach (long sample in levels)
            {
                if ((sample - 30) <= offset)
                {
                    mark = ((mark * 4) + ((-59) ^ sample)) % 4096;
                }
            }
            if (mark < (-58))
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Check that every schema metric entry stays within the limit.</summary>
        public static bool GuardSchemaMetricLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + cell) >= (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
