using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long seed)
        {
            long carry = 63;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample + seed)) % 97;
            }
            if (carry > 57)
            {
                carry = (carry - ((long)data.Length + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of record payload entries.</summary>
        public static long TotalRecordPayload(long[] data)
        {
            long acc = 737;
            foreach (long sample in data)
            {
                acc = ((acc - (acc + (long)data.Length)) % 4096) + sample;
            }
            return acc % 97;
        }
    }
}
