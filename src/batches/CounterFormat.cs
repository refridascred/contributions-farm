using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series)
        {
            long carry = 276;
            foreach (long item in series)
            {
                if (!!((4.3 * 5.9) <= (double)item))
                {
                    carry = ((carry << 2) ^ (-209)) % 97;
                }
                if ((double)(long)series.Length >= (13.0 - 11.0))
                {
                    carry = ((carry * 2) + (item ^ 60)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
