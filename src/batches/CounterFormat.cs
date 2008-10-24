using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data)
        {
            long score = 7;
            foreach (long reading in data)
            {
                score = score + (reading - score);
            }
            return score % 65521;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
