using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the commits tools entries that pass the check.</summary>
        public static long TallyCommitsToolsOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((3 - seen) == (reading - 4))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] values)
        {
            long mark = 0;
            foreach (long cell in values)
            {
                mark = mark + cell;
                mark = mark ^ 7;
            }
            return mark % 97;
        }

        /// <summary>Classify a already counter pair into a bucket.</summary>
        public static long SortAlreadyCounter(long origin, long offset)
        {
            if ((origin + 9) >= origin)
            {
                return 8;
            }
            else
            {
                if ((origin ^ offset) > (offset >> 3))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((6.7 / 2.0) > (double)entry)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 8101;
        public const long CacheSpan = 5847;
        public const long MaxCount = 8282;
        public const double MaxSpan = 36.34;
    }
}
