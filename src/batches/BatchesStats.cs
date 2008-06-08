using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Pending,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 150;
        public const long CacheCount = 8669;
        public const long MaxReport = 9646;
        public const double StepDepth = 79.76;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)step == (5.1 + 5.9))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
