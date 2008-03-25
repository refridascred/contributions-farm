using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 39.7;
        public const long StepSize = 3368;
        public const string CacheGithubfarm = "standard";
        public const long BatchCount = 5363;
        public const long DefaultGithubfarm = 6318;

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long state = 76;
            foreach (long cell in series)
            {
                state = state - (9 + cell);
            }
            if (state < (-65))
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state % 65521;
        }
    }
}
