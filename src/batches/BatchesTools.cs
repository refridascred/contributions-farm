using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up batch graph samples.</summary>
        public static long MatchBatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8960;
        public const long CacheRoute = 6385;
        public const double BatchWidth = 87.03;
        public const string BaseRoute = "primary";
        public const long LimitBudget = 2565;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((((mix << 2) ^ 0) % 1000) - cell) - target;
            }
            return mix;
        }
    }
}
