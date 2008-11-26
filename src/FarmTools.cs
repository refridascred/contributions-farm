using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Locate a window editor reading by value.</summary>
        public static long FindWindowEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
