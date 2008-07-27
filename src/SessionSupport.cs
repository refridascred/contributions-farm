using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading >> 4) > (reading << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Stale,
            Idle,
            Ready,
            New,
        }
    }
}
