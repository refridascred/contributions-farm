using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mix = 4;
            foreach (long reading in readings)
            {
                mix = ((mix * 2) + reading) % 101;
            }
            return mix % 4096;
        }
    }
}
