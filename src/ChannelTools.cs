using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics channel samples.</summary>
        public static long CombineMetricsChannel(long[] levels)
        {
            long carry = -9;
            foreach (long sample in levels)
            {
                carry = ((carry * 4) + (carry & 3)) % 1000;
                carry = (carry + sample) % 1000;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long RetryRecord = 7918;
        public const double StepDepth = 22.39;
        public const long DefaultCount = 7093;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
