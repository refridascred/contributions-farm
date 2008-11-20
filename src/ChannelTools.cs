using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate report format samples.</summary>
        public static long TotalReportFormat(long[] data)
        {
            long state = 5;
            foreach (long reading in data)
            {
                state = (state << 2) ^ (reading + 477);
            }
            return state;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
