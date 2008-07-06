using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 39.01;
        public const string CacheBudget = "staging-v2";
        public const long BaseLayout = 959;

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2211;
        public const long LimitAlready = 2185;
        public const double HardDepth = 33.56;
        public const long BurstAlready = 5340;
    }
}
