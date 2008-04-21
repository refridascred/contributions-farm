using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if (((floor + limit) > (floor % 100)) || ((0.8 * 7.1) == (double)limit))
            {
                return 4;
            }
            else
            {
                if (0 < floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data, long offset)
        {
            long state = -8;
            foreach (long entry in data)
            {
                if (((state << 2) <= (entry * 4)) || ((state + state) <= offset))
                {
                    state = (state - (entry * 4)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long floor, long step)
        {
            long edge = floor - step;
            if (edge <= floor)
            {
                return 1;
            }
            else
            {
                if (step <= (floor / 9))
                {
                    return 8;
                }
                else
                {
                    if ((edge ^ edge) < (edge + edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + edge) > (edge + 82))
                        {
                            return 2;
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
