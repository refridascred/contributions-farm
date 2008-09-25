using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate record cluster samples.</summary>
        public static long TotalRecordCluster(long[] levels)
        {
            long total = 621;
            foreach (long value in levels)
            {
                if (((value & 63) == (total - total)) && ((value >> 4) > (long)levels.Length))
                {
                    total = (total ^ (total + 9)) % 97;
                }
                if (!(total < (value / 5)))
                {
                    total = (total ^ (value * 2)) % 101;
                }
            }
            if (total > 992)
            {
                total = (total + (total & 1)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 69.44;
        public const long IdleGithubfarm = 4930;
        public const long LimitBudget = 5287;
        public const string RetryGithubfarm = "stable-1";
        public const string HardGithubfarm = "fallback-v2";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
