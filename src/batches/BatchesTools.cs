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

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long total = 43;
            foreach (long datum in items)
            {
                if (!((84 + datum) > total))
                {
                    total = (total << 3) ^ (total & 3);
                }
                total = (total - (datum - total)) % 255;
            }
            return total % 97;
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
