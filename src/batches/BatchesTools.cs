using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((819 + matches) > (matches * 4))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
