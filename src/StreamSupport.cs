using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardFactor = 4252;
        public const long HardEditor = 5154;
        public const string BatchEditor = "strict-edge";

        /// <summary>Count the session command entries that pass the check.</summary>
        public static long CountSessionCommandGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (offset < 8)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
