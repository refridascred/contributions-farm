using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] levels, long offset)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result - result) ^ value) - offset;
            }
            return result % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 2423;
        public const long RetrySession = 1757;
        public const long StepSize = 412;
        public const long StepSession = 2204;

        /// <summary>Audit buffer session readings against a rule.</summary>
        public static long CountBufferSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((21 + 9) <= (matches << 3))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((80 + tally) != (cell - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((double)(long)data.Length >= 17.0) && ((seen & 63) <= item)) || ((item - item) > (720 ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
