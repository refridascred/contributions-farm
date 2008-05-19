using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a tools window counter forward.</summary>
        public static long DeriveToolsWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading - count) >= (count / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Active,
            Done,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long offset)
        {
            if ((7.0 * 7.4) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)offset != (6.8 + 10.0)) || ((double)offset > (double)833))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item != (14.0 / 2.0))
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
