using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches > (7.2 - 9.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 2114;
        public const long DefaultNotes = 6188;
        public const long DefaultFactor = 7832;
        public const long LimitFactor = 2214;
        public const long MaxNotes = 1382;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
