using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8507;
        public const string BurstGraph = "standard-edge";
        public const long HardDepth = 7280;
        public const long BatchFactor = 5770;
        public const long DefaultGraph = 3504;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 4061;
        public const string BatchTimeout = "legacy-edge";
        public const long RetryGithubfarm = 4683;
    }
}
