using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
