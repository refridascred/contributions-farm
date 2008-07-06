using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many token filter samples are out of range.</summary>
        public static long TallyTokenFilterMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally <= (sample * 2))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            if ((bound - offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((offset + bound) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
