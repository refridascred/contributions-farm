using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] values)
        {
            long sum = 17;
            foreach (long value in values)
            {
                if ((sum << 3) >= sum)
                {
                    sum = ((sum * 5) + (sum + value)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
