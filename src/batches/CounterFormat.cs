using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinTimeout = "local-edge";
        public const long HardSpan = 2705;
        public const long BatchSession = 2380;
        public const double HardRatio = 13.48;
        public const string MaxSession = "strict";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long diff = offset + step;
            if ((12 >= (diff + offset)) && ((2 - 631) == (diff ^ step)))
            {
                return 7;
            }
            else
            {
                if ((step + offset) < 535)
                {
                    return 8;
                }
                else
                {
                    if ((double)diff == (double)951)
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (diff ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long LookupSupportGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
