using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3960;
        public const string WindowSpan = "local-1";
        public const string DefaultMetrics = "latest-edge";

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "staging";
        public const long SoftWidth = 6610;
        public const long IdleEntry = 3929;

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6344;
        public const long BurstSession = 4613;
        public const long BurstTimeout = 676;
    }
}
