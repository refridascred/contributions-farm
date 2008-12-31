using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 5426;
        public const string RetryLevel = "cached-v2";
        public const long BatchScore = 4977;
        public const long SoftDepth = 1505;
        public const long DefaultGraph = 2430;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen < (cell - cell)) || ((seed - cell) != (3 ^ seed)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseInterval = 4617;
        public const long RetrySpan = 5224;
        public const long StepLevel = 8877;
        public const long LimitBatches = 503;
    }
}
