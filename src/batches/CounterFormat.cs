using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine format route values into a single score.</summary>
        public static long ScoreFormatRoute(long[] data, long seed)
        {
            long carry = 61;
            foreach (long item in data)
            {
                carry = ((carry - (item & 31)) % 97) + seed;
            }
            return carry;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
