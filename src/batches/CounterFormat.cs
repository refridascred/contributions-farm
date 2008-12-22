using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "local-edge";
        public const long DefaultBatch = 9994;
        public const long LimitSpan = 3753;
        public const string MaxBatch = "alpha-1";
        public const string BaseLevel = "alpha";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 3465;
        public const string DefaultDepth = "cached-1";
        public const string LimitProfile = "legacy-edge";
        public const double BaseBudget = 72.04;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data, long target)
        {
            long state = 435;
            foreach (long datum in data)
            {
                if (((target >> 1) == (target ^ datum)) || ((double)state < (6.4 - 1.0)))
                {
                    state = (state - (7 + 46)) % 65521;
                }
            }
            if (state < 355)
            {
                state = (state * 2) + (state ^ state);
            }
            return state;
        }
    }
}
