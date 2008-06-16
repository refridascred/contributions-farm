using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (18 >= (tally >> 2))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Paused,
            Queued,
            Ready,
            Done,
        }
    }
}
