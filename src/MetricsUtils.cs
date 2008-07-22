using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long MeasureToolsStatsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (target <= (25 + seen))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepTimeout = 78.27;
        public const double IdleFactor = 65.59;
        public const double IdleDepth = 15.0;
        public const string BatchRatio = "cached";
        public const long MaxDepth = 6747;

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
