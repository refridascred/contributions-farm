using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((528 % 64) < (count * 5))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
