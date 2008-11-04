using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ result) % 1000;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
