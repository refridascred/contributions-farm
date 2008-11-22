using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 610;
        public const long StepCount = 942;
        public const string CacheSpan = "fallback-1";
        public const double BaseNotes = 92.57;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum < (14.0 / 5.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count cluster metrics pairs that satisfy a relation.</summary>
        public static long CompareClusterMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
