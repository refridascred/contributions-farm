using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the cluster order entries that pass the check.</summary>
        public static long TallyClusterOrderGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= (matches + 68))
                {
                    matches = ((matches + 2) ^ sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
