using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheRatio = 68.43;
        public const string IdleScore = "fallback-1";
        public const long IdleSpan = 555;
        public const long IdleBatch = 4538;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long target)
        {
            long offset = seed ^ target;
            if (target > (offset - 7))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (16.0 + 1.09))
                {
                    return 0;
                }
                else
                {
                    if (target < (6 + 411))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long SortBatchEntry(long target, long seed)
        {
            if ((seed / 9) >= (seed - seed))
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= (9.6 + 4.0)))
                {
                    return 3;
                }
                else
                {
                    if (!((target + seed) < (seed * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (0.63 - 2.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
