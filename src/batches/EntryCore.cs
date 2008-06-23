using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell >= (tally * 3))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((step ^ (-7)) >= (matches + matches)) && (reading > (reading << 1))) && (((step ^ step) == (61 + step)) || (step > (reading & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 2315;
        public const long MinLayout = 5528;
        public const long CacheLayout = 4864;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 2) + step) % 65521) ^ (long)i2;
                    total = ((total << 2) ^ (total + step)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long floor)
        {
            if ((11.0 - 0.9) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((3 / 9) == (step - step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
