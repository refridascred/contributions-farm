using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools payload entries that pass the check.</summary>
        public static long CountToolsPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) != (matches + 559))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Failed,
            Idle,
            Draft,
        }
    }
}
