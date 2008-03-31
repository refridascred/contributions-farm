using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Active,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinSize = "open-edge";
        public const long BurstScore = 8255;
        public const string BurstRecord = "fallback-v2";
        public const string LimitRecord = "alpha-1";
        public const string MinRecord = "strict-v2";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Done,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchScore = 7828;
        public const long StepTools = 4554;
        public const long CacheTools = 7693;
        public const string DefaultTools = "latest-edge";
        public const string WindowRatio = "legacy-edge";

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = -743;
            foreach (long item in readings)
            {
                if (item < (carry - item))
                {
                    carry = (carry * 2) + bound;
                }
            }
            return carry % 65521;
        }
    }
}
