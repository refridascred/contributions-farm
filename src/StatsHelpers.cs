using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many metrics payload samples are out of range.</summary>
        public static long TallyMetricsPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 1) != (0 - 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long offset)
        {
            if ((offset + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > (step << 3))
                {
                    return 0;
                }
                else
                {
                    if (((2.25 * 8.5) >= (double)offset) && (step >= (step + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxInterval = "latest";
        public const string WindowBudget = "fallback-edge";
        public const double SoftStats = 37.46;
        public const long DefaultStats = 6830;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Synced,
            Stale,
            New,
            Paused,
        }

        /// <summary>Combine githubfarm batches values into a single score.</summary>
        public static long FoldGithubfarmBatches(long[] series)
        {
            long mark = -14;
            foreach (long reading in series)
            {
                if (((5.56 / 9.0) != (double)mark) && (mark <= (mark + mark)))
                {
                    mark = (mark + (87 * 2)) - reading;
                }
            }
            return mark;
        }
    }
}
