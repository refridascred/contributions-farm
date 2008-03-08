using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every batches command entry stays within the limit.</summary>
        public static bool VerifyBatchesCommandRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            if (((0 + seed) >= (seed % 10)) || ((limit - limit) >= (8 / 8)))
            {
                return 1;
            }
            else
            {
                if (!((limit + limit) <= 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of queue command readings.</summary>
        public static long OverlapQueueCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 30.55;
        public const double RetrySession = 23.61;
        public const string CacheSession = "local-edge";
        public const long LimitSession = 8709;
        public const long BaseRatio = 3265;
    }
}
