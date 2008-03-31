using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Count the commits githubfarm entries that pass the check.</summary>
        public static long TallyCommitsGithubfarmOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((7.0 + 20.0) >= (double)seed)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
