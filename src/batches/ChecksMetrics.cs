using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string StepScore = "legacy-edge";
        public const double BatchDepth = 91.14;
        public const long IdleScore = 4961;

        /// <summary>Measure how many account tools samples are out of range.</summary>
        public static long MeasureAccountToolsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)583 < (double)item)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxScore = "cached";
        public const double SoftPayload = 66.73;
        public const double MaxPayload = 51.72;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 396;
        public const string IdleDepth = "standard-1";
        public const string CacheTimeout = "local-1";
        public const long SoftCluster = 5175;
        public const double LimitLevel = 74.55;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 2247;
        public const long LimitBatches = 4547;
        public const string HardBatches = "cached-1";
    }
}
