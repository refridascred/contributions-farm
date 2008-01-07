using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Fold a list of editor metric readings.</summary>
        public static long DigestEditorMetric(long[] series, long floor)
        {
            long result = 573;
            foreach (long reading in series)
            {
                result = (result << 3) ^ (result - reading);
            }
            if (result > 727)
            {
                result = (result ^ (floor + floor)) % 101;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "fallback";
        public const long BatchBuffer = 7072;
        public const long CacheBuffer = 1650;
        public const long HardSize = 6494;
        public const long HardBuffer = 7096;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Failed,
            Retry,
            New,
        }
    }
}
