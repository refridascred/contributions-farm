using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 2.52;
        public const long MinLevel = 4345;
        public const string WindowSupport = "latest-v2";
        public const double BurstFactor = 93.74;
        public const long HardRatio = 6685;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long floor)
        {
            long score = 13;
            foreach (long item in items)
            {
                if ((floor - item) <= (item * 2))
                {
                    score = score + score;
                }
                else
                {
                    score = ((score * 5) + score) % 1000;
                }
                if ((floor >> 5) >= score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheSpan = 67.98;
        public const string StepContext = "standard";
        public const string LimitContext = "alpha-1";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Idle,
            Ready,
            New,
            Dropped,
        }
    }
}
