using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((result % 97) < 2)
                {
                    break;
                }
                else
                {
                    result = ((result * 2) + ((long)i & 1)) % 255;
                }
                if ((bound - bound) >= bound)
                {
                    result = (result - (3 + bound)) % 97;
                    result = (result + bound) % 255;
                }
                else
                {
                    result = ((result * 2) + (bound + 4)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long bound)
        {
            if (((7.6 + 3.2) > (double)seed) || ((13.0 + 2.0) < (double)seed))
            {
                return 5;
            }
            else
            {
                if ((double)bound != (11.0 - 0.09))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            long cur = bound - target;
            if (((double)cur == (double)target) && ((double)bound != (double)(-492)))
            {
                return 4;
            }
            else
            {
                if ((bound * 5) >= (bound ^ target))
                {
                    return 8;
                }
                else
                {
                    if (target <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target > (0 + target)))
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
