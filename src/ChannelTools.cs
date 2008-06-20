using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long floor)
        {
            long state = 50;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ floor) + item;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long seed)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                carry = carry ^ (entry & 63);
                carry = ((carry * 2) + (entry ^ seed)) % 97;
            }
            if (carry < 5)
            {
                carry = (carry + (carry + 6)) % 1000;
            }
            return carry % 4096;
        }
    }
}
