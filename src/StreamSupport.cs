using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double gain = span;
            if (gain >= (double)2)
            {
                gain = (gain + (double)731) + ratio;
            }
            else
            {
                gain = gain - (double)51;
            }
            return gain + (double)620;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long step = target + target2;
            if ((353 + step) > (999 & 1))
            {
                return 6;
            }
            else
            {
                if ((step << 1) < step)
                {
                    return 3;
                }
                else
                {
                    if ((double)target2 > 9.56)
                    {
                        return 2;
                    }
                    else
                    {
                        if (step > (target2 % 16))
                        {
                            return 0;
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
}
