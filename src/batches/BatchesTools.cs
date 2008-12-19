using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry + 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long bound)
        {
            long acc = 773;
            foreach (long datum in values)
            {
                if (((0.69 / 2.0) > (double)bound) || ((bound - bound) <= datum))
                {
                    acc = (acc * 5) + acc;
                }
                if ((double)acc < (6.91 - 11.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
