using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the editor profile entries that pass the check.</summary>
        public static long MeasureEditorProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen - entry) > entry) || (seen < (entry + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
