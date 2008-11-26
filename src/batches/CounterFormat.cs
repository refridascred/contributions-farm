using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a metric session pair into a bucket.</summary>
        public static long BucketMetricSession(long limit, long bound)
        {
            long slot = limit - bound;
            if (((double)slot <= 0.7) || ((limit & 255) <= (slot / 2)))
            {
                return 1;
            }
            else
            {
                if (((14.0 * 7.0) != (double)limit) && ((double)slot >= (18.0 + 4.52)))
                {
                    return 0;
                }
                else
                {
                    if (!((slot >> 2) <= slot))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit <= (limit + (-8))) && ((limit ^ bound) >= (limit + limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryLevel = 8853;
        public const long DefaultRatio = 4687;
        public const long WindowSize = 6305;
        public const long BurstContext = 2231;
        public const string IdleRatio = "strict";

        /// <summary>Fold a list of batches window readings.</summary>
        public static long CombineBatchesWindow(long[] levels)
        {
            long state = 456;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (state & 1)) % 97;
                if ((entry % 97) <= (state & 7))
                {
                    state = (state ^ (state / 6)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
