using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftSpan = "cached";
        public const double SoftBudget = 15.49;
        public const double LimitGithubfarm = 25.82;
        public const double HardLevel = 96.52;

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples, long bound)
        {
            long mix = 17;
            foreach (long reading in samples)
            {
                mix = (mix * 2) + reading;
                if ((bound << 1) == (bound / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
