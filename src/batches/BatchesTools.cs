using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            long next = limit - seed;
            if ((limit ^ limit) >= next)
            {
                return 5;
            }
            else
            {
                if (((-924) - seed) >= (limit % 97))
                {
                    return 0;
                }
                else
                {
                    if (((-9) + seed) <= (next << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double scale, double offset)
        {
            double mean = 6.8;
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean + mean;
        }
    }
}
