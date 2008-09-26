using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((entry * 4) < offset) || (251 > (matches ^ entry))) && ((7.3 * 0.5) <= (double)offset))
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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 7045;
        public const long MinEditor = 2602;
        public const double DefaultEditor = 22.85;
        public const long HardDepth = 5048;
        public const double BurstEditor = 90.63;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
