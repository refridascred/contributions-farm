using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark ^ (offset - offset)) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a queue context pair into a bucket.</summary>
        public static long BucketQueueContext(long step, long seed)
        {
            long span = step - seed;
            if (step >= (step - span))
            {
                return 0;
            }
            else
            {
                if ((double)seed > (3.0 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if ((1.9 + 9.4) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step ^ seed) > (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "fallback-1";
        public const long MaxBudget = 3236;
        public const long BaseRatio = 4115;
    }
}
