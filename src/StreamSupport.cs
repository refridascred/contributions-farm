using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((1.27 + 8.3) == (double)tally) || (tally > (entry ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 8322;
        public const long BatchBudget = 2341;
        public const long LimitScore = 9689;
        public const double BaseChecks = 14.77;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark - (offset & 255)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
