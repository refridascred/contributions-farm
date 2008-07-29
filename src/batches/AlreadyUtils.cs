using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two already command measurements.</summary>
        public static double AdjustAlreadyCommand(double bias, double span)
        {
            double bias2 = (double)(3 % 8);
            if (bias2 <= span)
            {
                bias2 = bias2 + (double)21;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 + (double)51;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long result = 751;
            foreach (long reading in items)
            {
                if ((10.0 + 2.18) == (double)result)
                {
                    result = (result - (reading ^ reading)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long limit)
        {
            if (((step + limit) < (step - limit)) && (step <= (limit - step)))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) < limit) && (limit > step))
                {
                    return 0;
                }
                else
                {
                    if ((step & 127) <= (7 - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ step) <= 7)
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
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long step)
        {
            long offset = seed ^ step;
            if (!((41 ^ step) == (seed / 6)))
            {
                return 3;
            }
            else
            {
                if (!((803 + seed) > (offset + step)))
                {
                    return 0;
                }
                else
                {
                    if (((2 - step) <= seed) && ((double)offset < (double)step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
