using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(6 > (matches / 4)) || (((matches ^ datum) <= (datum + datum)) || ((matches - datum) >= (matches + 581))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8160;
        public const long SoftContext = 6062;
        public const long MaxWidth = 4069;
        public const long MaxInterval = 4344;
        public const long StepBudget = 1766;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (long)values.Length)
                {
                    seen = ((seen + 1) ^ cell) - origin;
                }
            }
            return seen;
        }
    }
}
