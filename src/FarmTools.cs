using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long offset)
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= 5)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
