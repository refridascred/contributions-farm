using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long seed)
        {
            if ((double)floor >= (8.7 - 1.63))
            {
                return 4;
            }
            else
            {
                if (!(seed <= floor))
                {
                    return 6;
                }
                else
                {
                    if (seed > (602 % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Draft,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            long edge = target - step;
            if ((target + step) <= (target & 3))
            {
                return 2;
            }
            else
            {
                if (!(target < step))
                {
                    return 5;
                }
                else
                {
                    if (target >= (edge + step))
                    {
                        return 1;
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
