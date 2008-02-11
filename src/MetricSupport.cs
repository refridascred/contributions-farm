using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6267;
        public const double StepTimeout = 9.88;
        public const long DefaultContext = 790;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((263 - item) >= (tally + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
