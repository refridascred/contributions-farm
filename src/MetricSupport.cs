using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster window readings against a bound.</summary>
        public static bool VerifyClusterWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitFactor = 88.55;
        public const long IdleQueue = 3701;
        public const long BaseSize = 212;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long result = 7;
            foreach (long cell in items)
            {
                result = (((result << 3) ^ ((long)items.Length << 2)) % 1000) + cell;
            }
            return result;
        }
    }
}
