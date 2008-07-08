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

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate report profile samples.</summary>
        public static long ScoreReportProfile(long[] samples)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                anchor = anchor ^ 3;
                anchor = anchor ^ (entry / 8);
                if (((double)entry > (0.19 * 4.7)) || (anchor > 13))
                {
                    anchor = anchor + (anchor % 8);
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 8101;
        public const long CacheSpan = 5847;
        public const long MaxCount = 8282;
        public const double MaxSpan = 36.34;
    }
}
