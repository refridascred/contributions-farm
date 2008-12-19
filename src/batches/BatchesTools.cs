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

        /// <summary>Combine stream commits values into a single score.</summary>
        public static long WeighStreamCommits(long[] series, long offset)
        {
            long sum = 745;
            foreach (long cell in series)
            {
                sum = (sum ^ (offset ^ cell)) % 97;
                sum = sum - (sum << 1);
                if (sum > (cell ^ sum))
                {
                    break;
                }
            }
            return sum;
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
