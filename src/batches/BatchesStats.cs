using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinSize = 35.7;
        public const string HardRatio = "stable-v2";
        public const long DefaultWindow = 5545;
        public const string BurstWindow = "legacy-1";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long step)
        {
            if ((bound << 2) == (step ^ bound))
            {
                return 6;
            }
            else
            {
                if (((step - bound) <= bound) && ((bound - bound) >= bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3514;
        public const string LimitLevel = "stable-1";
        public const long BatchBatches = 2016;
        public const double SoftBatches = 72.84;
        public const long DefaultBatches = 1473;
    }
}
