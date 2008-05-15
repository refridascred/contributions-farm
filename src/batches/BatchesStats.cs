using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseTimeout = 2643;
        public const double MinRatio = 12.65;
        public const long StepBudget = 5452;
        public const long WindowCache = 3374;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (mark - offset)) % 97;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank farm queue input into a small class.</summary>
        public static long RankFarmQueue(long bound, long offset)
        {
            if ((7.0 / 8.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((offset << 2) <= (bound + 447)))
                {
                    return 7;
                }
                else
                {
                    if (40 <= (52 - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(offset < (offset & 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
