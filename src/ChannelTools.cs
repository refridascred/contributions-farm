using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
