using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Closed,
            Pending,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstDepth = 9512;
        public const string SoftReport = "staging-v2";
        public const double RetryCount = 89.15;
        public const string DefaultRatio = "fallback-edge";
        public const long BaseFactor = 987;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Failed,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 92.97;
        public const double BatchCache = 21.18;
        public const double BaseCount = 34.26;

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxRatio = 76.76;
        public const long StepLayout = 4147;
        public const double BurstLayout = 77.24;
        public const long IdleDepth = 7811;
        public const long DefaultLayout = 4265;
    }
}
