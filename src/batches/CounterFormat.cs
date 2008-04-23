using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (!((floor - 64) >= (edge - edge)))
            {
                return 1;
            }
            else
            {
                if ((double)seed == (2.0 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 / 9.0) != (double)edge)
                    {
                        return 5;
                    }
                    else
                    {
                        if (edge >= (328 + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
