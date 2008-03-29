using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session farm counter forward.</summary>
        public static long RollSessionFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = result - (result + 435);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double gain = (offset + 4.36) / 7.0;
            if (gain < 3.32)
            {
                gain = (gain - (offset * 9.0)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (17.0 - 3.79);
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long RankReportCounter(long offset, long target)
        {
            long slot = offset ^ target;
            if (!((double)offset < (8.0 + 7.77)))
            {
                return 5;
            }
            else
            {
                if (!(offset >= (5 << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((slot + slot) >= ((-736) << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)slot != (2.0 / 5.0)) && ((offset % 12) < slot))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
