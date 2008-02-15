using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseScore = 8040;
        public const string StepCount = "legacy-v2";
        public const long RetryCluster = 9158;
        public const double StepCluster = 21.65;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8640;
        public const string WindowGraph = "alpha-v2";
        public const string IdleWidth = "cached-edge";
        public const double HardGraph = 44.57;
        public const long BurstGraph = 4317;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] samples, long limit)
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
    }
}
