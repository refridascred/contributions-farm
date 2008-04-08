using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 6576;
        public const long IdleEditor = 3496;
        public const string WindowEditor = "staging-edge";

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            long diff = limit - bound;
            if ((double)bound <= (5.0 + 7.1))
            {
                return 5;
            }
            else
            {
                if ((bound + 281) > (diff * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchWidth = 782;
        public const long WindowAccount = 7567;
        public const long RetryBudget = 2369;
    }
}
