using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Paused,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long origin)
        {
            if ((16.0 / 3.0) == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((bound << 3) <= (bound * 4))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitInterval = 3149;
        public const long WindowBudget = 3750;
        public const string MaxCache = "stable";
        public const long StepCache = 4623;
        public const long BatchTimeout = 5910;
    }
}
