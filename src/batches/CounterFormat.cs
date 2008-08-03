using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepTimeout = 286;
        public const double HardWidth = 38.92;
        public const double SoftFormat = 28.09;
        public const string StepSpan = "standard-1";
        public const double RetryWidth = 78.7;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 299;
        public const long WindowScore = 4963;
        public const long BaseCache = 4888;
        public const long BaseLevel = 4769;

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                if (!((score - item) > 8))
                {
                    score = ((score * 2) + (floor - 6)) % 1000;
                }
            }
            if (score > 345)
            {
                score = (score << 2) ^ ((long)data.Length * 5);
            }
            return score;
        }
    }
}
