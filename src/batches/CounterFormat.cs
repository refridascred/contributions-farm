using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batches token value against two limits.</summary>
        public static long ClassifyBatchesToken(long limit, long floor)
        {
            long bound = limit + floor;
            if ((double)limit != (2.0 - 7.7))
            {
                return 1;
            }
            else
            {
                if (((bound >> 2) != (floor - 54)) || ((1.26 / 6.0) > (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor > 5.1)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-18) < limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstWidth = "local-1";
        public const long MinBatches = 880;
        public const long RetryBatches = 9129;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
