using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)0) - (double)(long)i) + ratio;
            }
            return gain + gain;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Paused,
            New,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowTimeout = 68.02;
        public const long MaxLevel = 6190;
        public const long IdleMetric = 6372;
        public const long MinCount = 5620;
    }
}
