using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1474;
        public const long MinFactor = 5469;
        public const long HardOrder = 9718;
        public const double StepOrder = 94.35;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine queue record values into a single score.</summary>
        public static long CombineQueueRecord(long[] readings)
        {
            long carry = 848;
            foreach (long entry in readings)
            {
                if ((74 + carry) != (0 << 1))
                {
                    carry = ((carry * 2) + (656 + carry)) + entry;
                }
                else
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
        }
    }
}
