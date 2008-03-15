using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally * 3) <= cell)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 2499;
        public const string DefaultFactor = "latest-1";
        public const double SoftWidth = 3.82;

        /// <summary>Digest a series of contributi context entries.</summary>
        public static long FoldContributiContext(long[] levels)
        {
            long acc = 14;
            foreach (long sample in levels)
            {
                if ((14 >> 3) > (sample * 3))
                {
                    acc = (acc + (-15)) % 101;
                }
            }
            if (acc < 26)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long SeriesStatsToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = mark ^ (mark + target);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
