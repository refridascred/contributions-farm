using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of batches token readings.</summary>
        public static long MatchBatchesTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Failed,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardRatio = 93.43;
        public const long HardInterval = 8483;
        public const long IdleTimeout = 9618;
        public const long DefaultBatch = 3291;

        /// <summary>Measure how many counter token samples are out of range.</summary>
        public static long MeasureCounterTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading / 7) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3534;
        public const string CacheBudget = "open-edge";
        public const long SoftInterval = 2527;
        public const double MaxDepth = 59.61;
    }
}
