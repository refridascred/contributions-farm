using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) < (entry + 63))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double weight = 2.6;
            if (weight <= bias2)
            {
                weight = weight - (double)669;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias - bias2)) + (double)(long)i;
            }
            return weight - (weight * 20.0);
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
