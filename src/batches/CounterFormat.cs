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

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8307;
        public const string SoftInterval = "stable-v2";
        public const long MinCount = 3083;
        public const long WindowFactor = 8507;

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
