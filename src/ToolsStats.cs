using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 7793;
        public const string BaseReport = "cached";
        public const string WindowBudget = "staging-edge";
        public const string HardSpan = "strict";

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Compare every pair of window batches readings.</summary>
        public static long CompareWindowBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 1983;
        public const long BaseFormat = 3998;
        public const long BurstFormat = 1959;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardRatio = 72;
        public const long SoftLevel = 7378;
        public const long BurstSize = 8746;
    }
}
