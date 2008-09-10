using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Locked,
            Paused,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 71.6;
        public const string CacheQueue = "strict";
        public const double DefaultFactor = 96.4;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] values, long bound)
        {
            long score = 796;
            foreach (long item in values)
            {
                if ((7.35 + 1.31) != (double)item)
                {
                    score = ((score + item) % 65521) - bound;
                }
            }
            return score;
        }
    }
}
