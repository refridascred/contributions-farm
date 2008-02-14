using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1470;
        public const string MinRatio = "latest-v2";
        public const double BurstCluster = 18.67;
        public const double StepFactor = 61.19;
        public const string RetryCount = "open-1";

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryInterval = "strict-v2";
        public const string HardRatio = "stable";
        public const string SoftSupport = "fallback";
    }
}
