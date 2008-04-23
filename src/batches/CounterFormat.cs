using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Retry,
            Failed,
            Done,
            Active,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long step)
        {
            long prev = seed ^ step;
            if ((894 & 3) == (seed * 5))
            {
                return 4;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((seed >> 5) >= prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool ValidateBatchesQueueRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
