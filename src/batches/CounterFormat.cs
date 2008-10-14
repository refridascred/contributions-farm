using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache layout samples.</summary>
        public static long FoldCacheLayout(long[] series)
        {
            long score = 784;
            foreach (long cell in series)
            {
                if (!((score % 97) > (cell + score)))
                {
                    score = ((score << 3) ^ (cell % 64)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 2155;
        public const long StepContext = 9296;
        public const long SoftContext = 3826;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}
