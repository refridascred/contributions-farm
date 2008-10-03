using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches >> 2) != (sample << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3539;
        public const long SoftCluster = 9143;
        public const double StepCluster = 15.24;
        public const long StepWidth = 3421;

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
