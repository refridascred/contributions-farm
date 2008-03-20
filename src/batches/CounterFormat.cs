using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
