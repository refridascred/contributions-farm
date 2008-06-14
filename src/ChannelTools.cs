using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long target)
        {
            long acc = -7;
            foreach (long item in values)
            {
                if (!((8.6 / 5.0) >= (double)acc))
                {
                    acc = (acc - (acc & 1)) % 101;
                }
                if (((4 - acc) <= (acc / 2)) && ((item & 7) > target))
                {
                    acc = acc + (item & 63);
                }
            }
            return acc;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftDepth = 58.26;
        public const string StepCount = "standard-v2";
        public const string BurstRatio = "strict-edge";
    }
}
