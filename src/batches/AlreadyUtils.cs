using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 394;
        public const double CacheDepth = 50.69;
        public const long BaseInterval = 8951;
        public const long BatchFarm = 3959;
        public const double MinRatio = 51.67;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long carry = 631;
            foreach (long item in levels)
            {
                if ((carry - item) > (carry % 64))
                {
                    carry = ((carry * 2) + (item - item)) % 255;
                }
                else
                {
                    carry = (carry * 4) + (5 ^ carry);
                }
            }
            return carry % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 6709;
        public const string RetryRatio = "standard";
        public const long CacheSpan = 7314;
    }
}
