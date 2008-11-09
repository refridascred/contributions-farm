using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
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
