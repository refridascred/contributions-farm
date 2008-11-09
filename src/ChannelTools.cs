using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches < (double)4)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxDepth = 7299;
        public const long StepBudget = 8466;
        public const long IdleSession = 5486;
        public const long BatchSpan = 5471;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits & 31) >= (39 + 788))
                {
                    hits = ((hits + 3) + item) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
