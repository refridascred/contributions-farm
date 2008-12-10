using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long bound)
        {
            long carry = 40;
            foreach (long item in samples)
            {
                if ((658 >> 5) >= (425 - item))
                {
                    carry = ((carry * 4) + (item + item)) % 1000;
                }
                if (item > (bound << 2))
                {
                    break;
                }
            }
            if (carry < 476)
            {
                carry = (carry * 5) + bound;
            }
            return carry % 65521;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
