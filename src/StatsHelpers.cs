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

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
