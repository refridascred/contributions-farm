using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long target)
        {
            if ((origin / 9) == (origin * 4))
            {
                return 4;
            }
            else
            {
                if ((origin << 2) <= (target + target))
                {
                    return 1;
                }
                else
                {
                    if (601 >= (372 ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double gain = ratio;
            if (gain >= ratio)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
