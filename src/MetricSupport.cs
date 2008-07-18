using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a githubfarm stream sample.</summary>
        public static long LocateGithubfarmStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultTimeout = 94.65;
        public const long BurstWindow = 4475;
        public const string BatchLevel = "strict-v2";
    }
}
