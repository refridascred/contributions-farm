using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowSize = "open";
        public const long LimitAccount = 443;
        public const long BaseRatio = 4985;
        public const double HardSize = 1.89;
        public const long IdleAccount = 6590;

        /// <summary>Count route format pairs that satisfy a relation.</summary>
        public static long PairRouteFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long SortCommitsProfile(long origin, long seed)
        {
            if (origin > (1 / 7))
            {
                return 0;
            }
            else
            {
                if (seed <= origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
