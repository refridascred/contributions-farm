using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Paused,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "strict-v2";
        public const long StepFactor = 2034;
        public const long DefaultSpan = 4171;
        public const string BaseRecord = "standard-edge";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 801;
        public const double RetryBatches = 53.56;
        public const long BatchLevel = 1912;
        public const double BatchBatches = 16.6;
    }
}
