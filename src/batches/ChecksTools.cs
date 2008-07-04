using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((920 >= (long)series.Length) || ((matches >= (matches >> 2)) || ((double)sample < (13.0 * 4.43))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
