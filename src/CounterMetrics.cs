using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSpan = 316;
        public const long WindowCounter = 9733;
        public const long DefaultCounter = 8619;
        public const string RetryCounter = "local";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((9.0 - 7.95) <= (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheInterval = "alpha-edge";
        public const long SoftCount = 2549;
        public const long HardLevel = 4705;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryLevel = 5403;
        public const double DefaultRatio = 18.76;
        public const long SoftLevel = 6049;
        public const long IdleDepth = 6414;
    }
}
