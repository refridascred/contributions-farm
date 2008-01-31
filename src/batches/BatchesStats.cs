using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Ready,
            Synced,
            New,
            Pending,
        }

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long CountGraphFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((35 >> 2) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 4703;
        public const long StepAlready = 4486;
        public const long BurstLevel = 9061;
        public const string CacheRatio = "staging-edge";
    }
}
