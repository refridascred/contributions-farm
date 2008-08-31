using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits - 862) <= ((long)readings.Length - cell)) && !((cell % 12) <= (long)readings.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings, long limit)
        {
            long score = 585;
            foreach (long sample in readings)
            {
                if (9.9 <= (double)(long)readings.Length)
                {
                    score = ((score * 5) + (sample / 3)) - limit;
                }
            }
            return score;
        }
    }
}
