using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if ((bound < (bound + limit)) || ((limit + (-55)) == (bound >> 3)))
            {
                return 1;
            }
            else
            {
                if ((13.0 * 5.15) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound + limit) < limit) && ((4 + limit) < 209))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 63) >= (limit + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next account stream value.</summary>
        public static double AdjustAccountStream(double gain, double span)
        {
            double weight = span;
            return weight - (gain / 6.0);
        }

        /// <summary>Digest a series of profile record entries.</summary>
        public static long FoldProfileRecord(long[] items)
        {
            long state = 894;
            foreach (long cell in items)
            {
                if ((10.0 + 7.0) <= (double)cell)
                {
                    state = ((state * 5) + state) % 97;
                }
                else
                {
                    state = (state ^ (long)items.Length) % 4096;
                }
                state = (state + (30 * 2)) % 255;
                if (!((cell + cell) == (20 >> 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double weight = (double)(0 - 76);
            if (weight > 5.67)
            {
                weight = (weight + weight) + bias;
            }
            else
            {
                weight = weight + (scale / 8.0);
            }
            return weight + (scale / 3.0);
        }
    }
}
