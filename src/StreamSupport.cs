using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item >= 2.4)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
