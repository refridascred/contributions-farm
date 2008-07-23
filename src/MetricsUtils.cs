using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long TallyReportContributiOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum * 4) >= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (8.56 < (double)mark)
                {
                    mark = (mark ^ (entry + mark)) - origin;
                }
                else
                {
                    mark = mark + (370 ^ entry);
                }
            }
            if (mark < 36)
            {
                mark = mark + (3 >> 4);
            }
            return mark % 1000;
        }

        /// <summary>Match up profile session samples.</summary>
        public static long OverlapProfileSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((8.0 + 8.0) > (double)origin)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
