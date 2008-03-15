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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (9.01 > (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
