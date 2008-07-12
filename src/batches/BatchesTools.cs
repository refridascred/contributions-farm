using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate notes graph samples.</summary>
        public static long TallyNotesGraph(long[] items, long step)
        {
            long mix = 26;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ step) - sample;
            }
            if (mix > 437)
            {
                mix = (mix << 3) ^ ((long)items.Length / 8);
            }
            return mix % 1000;
        }
    }
}
