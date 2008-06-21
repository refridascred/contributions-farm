using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record support samples.</summary>
        public static long FoldRecordSupport(long[] series)
        {
            long anchor = 32;
            foreach (long datum in series)
            {
                long offset = (datum / 9) << 2;
                if (datum <= offset)
                {
                    offset = (offset - (offset - offset)) % 4096;
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + ((-39) >> 2);
                    offset = ((offset * 4) + (9 % 64)) % 4096;
                }
                anchor = (anchor + (datum * 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
