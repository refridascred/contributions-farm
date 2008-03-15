using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 8713;
        public const string DefaultSize = "legacy-v2";
        public const double LimitWindow = 66.88;

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series)
        {
            long anchor = 489;
            foreach (long cell in series)
            {
                anchor = anchor - (cell >> 5);
                if (((double)anchor < (18.0 - 10.0)) && ((2.8 / 4.0) != (double)anchor))
                {
                    anchor = (anchor ^ (cell % 97)) % 101;
                }
                if ((double)cell >= (1.62 - 0.91))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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
