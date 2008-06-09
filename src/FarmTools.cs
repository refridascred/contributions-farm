using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!!((0.18 * 0.4) > (double)cell))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up order farm samples.</summary>
        public static long MatchOrderFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long origin, long bound)
        {
            if (bound < (origin + bound))
            {
                return 7;
            }
            else
            {
                if ((origin / 9) <= (origin ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
