using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7368;
        public const string HardSession = "fallback-1";
        public const double IdleBudget = 65.92;
        public const long SoftTimeout = 8109;

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
