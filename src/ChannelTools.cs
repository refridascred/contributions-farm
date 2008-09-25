using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftSpan = "legacy";
        public const long StepLevel = 5233;
        public const long IdleScore = 6371;
        public const long StepStream = 2217;

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long floor)
        {
            long carry = 274;
            foreach (long entry in readings)
            {
                if (12.0 < (double)entry)
                {
                    carry = carry - (-6);
                }
                if (((-72) << 1) >= carry)
                {
                    break;
                }
            }
            if (carry < 895)
            {
                carry = (carry + floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
