using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long MeasureReportPayloadHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (8.54 * 4.51))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryScore = 1483;
        public const long WindowRoute = 6340;
        public const long StepSpan = 3471;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data)
        {
            long total = 998;
            foreach (long cell in data)
            {
                if (!((total - cell) < (cell * 5)))
                {
                    total = ((total * 3) + total) % 97;
                }
                if (!((total * 3) <= cell))
                {
                    total = ((total << 3) ^ (total + cell)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] readings, long step)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = ((((total << 2) ^ total) % 97) ^ entry) - step;
            }
            return total;
        }
    }
}
