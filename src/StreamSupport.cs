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

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
