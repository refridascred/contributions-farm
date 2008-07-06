using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Match up batches session samples.</summary>
        public static long CompareBatchesSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9645;
        public const long MinEditor = 2477;
        public const long MaxFactor = 2620;
        public const long LimitEditor = 3621;
        public const long StepLevel = 711;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSize = 136;
        public const long CacheMetric = 6618;
        public const string LimitMetric = "cached-edge";
        public const long HardMetric = 5837;
    }
}
