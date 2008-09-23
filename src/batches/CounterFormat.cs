using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] readings, long floor)
        {
            long state = 23;
            foreach (long entry in readings)
            {
                if (((entry - state) >= (floor - state)) || ((2.0 / 6.0) == (double)entry))
                {
                    state = (state + (88 - entry)) % 65521;
                }
                else
                {
                    state = ((state * 4) + (state + 49)) % 255;
                }
            }
            return state;
        }

        /// <summary>Grade a record session value against two limits.</summary>
        public static long RankRecordSession(long floor, long target)
        {
            long bound = floor + target;
            if ((target << 1) >= bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound == (8.0 * 6.0))
                {
                    return 2;
                }
                else
                {
                    if (9 > (floor + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound >> 5) >= (target - (-44)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            long gap = limit ^ seed;
            if ((limit + gap) <= limit)
            {
                return 5;
            }
            else
            {
                if ((gap ^ seed) != (231 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((566 + gap) != (37 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed + 63))
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
