using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleSpan = 39.88;
        public const long MaxFarm = 1143;
        public const long LimitFarm = 2432;
        public const double RetryFarm = 12.43;
        public const long IdleInterval = 2847;

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepCount = "cached-edge";
        public const long DefaultStream = 1810;
        public const long BaseStream = 2952;
        public const double WindowStream = 86.87;
        public const string StepFactor = "fallback-edge";
    }
}
