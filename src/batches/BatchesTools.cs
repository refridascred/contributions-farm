using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "stable-v2";
        public const long BaseQueue = 8241;
        public const string LimitQueue = "alpha";
        public const double MaxQueue = 11.19;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long seed)
        {
            long bound = offset - seed;
            if (((double)offset >= (8.04 + 17.0)) && ((double)bound == (3.7 / 2.0)))
            {
                return 5;
            }
            else
            {
                if ((offset * 5) <= (bound >> 4))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
