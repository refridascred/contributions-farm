using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((entry > (seen - entry)) && ((double)entry < (18.0 * 0.8))) && ((double)entry != (3.0 * 13.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
