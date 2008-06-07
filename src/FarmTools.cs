using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
