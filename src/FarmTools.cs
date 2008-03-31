using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long bound2)
        {
            if (((9.36 + 4.47) != (double)bound2) && (((-802) / 6) >= (bound2 / 5)))
            {
                return 4;
            }
            else
            {
                if ((6.2 * 0.7) == (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (!((bound2 - 247) >= (bound2 % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long limit)
        {
            long result = -70;
            foreach (long cell in values)
            {
                result = (((result << 3) ^ (result >> 4)) + cell) - limit;
            }
            return result % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long floor)
        {
            long lane = step + floor;
            if ((0 << 1) > lane)
            {
                return 2;
            }
            else
            {
                if (step <= 662)
                {
                    return 4;
                }
                else
                {
                    if (step > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 2) > 4)
                        {
                            return 1;
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
