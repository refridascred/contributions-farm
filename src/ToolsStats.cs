using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long origin)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = (anchor - (origin ^ origin)) % 255;
                if ((double)entry > (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor % 8)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor + (998 >> 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long RollCommitsCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if (total <= 328)
                {
                    total = (total - (total >> 5)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 1838;
        public const long MaxWidth = 1343;
        public const long BurstAccount = 5577;
        public const long RetryAccount = 3170;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((double)matches < 4.88))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Count stream filter pairs that satisfy a relation.</summary>
        public static long CompareStreamFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + tally) == ((long)values.Length ^ value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
