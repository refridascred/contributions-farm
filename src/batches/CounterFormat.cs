using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset >> 4) >= offset)
            {
                return 8;
            }
            else
            {
                if (((4.67 + 1.59) < (double)gap) || ((9.99 + 1.4) == (double)gap))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a commits graph counter forward.</summary>
        public static long SeriesCommitsGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long span = offset - target;
            if ((offset << 2) > (48 ^ offset))
            {
                return 3;
            }
            else
            {
                if ((span - target) < 967)
                {
                    return 1;
                }
                else
                {
                    if ((7.3 * 18.0) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
