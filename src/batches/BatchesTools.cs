using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
