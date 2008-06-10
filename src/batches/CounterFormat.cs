using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long step)
        {
            long step2 = target - step;
            if ((target % 16) > step2)
            {
                return 1;
            }
            else
            {
                if (step2 <= (11 / 3))
                {
                    return 7;
                }
                else
                {
                    if ((target >= (13 - step2)) || ((step2 + step) < step2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm session readings against a bound.</summary>
        public static bool CheckGithubfarmSessionBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long floor, long floor2)
        {
            if ((6.5 / 7.0) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((14.0 / 4.0) != (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 << 3) == (floor & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (15.0 < (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
