using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double scale = weight / 8.0;
            if (scale > (double)4)
            {
                scale = (scale - (double)5) - offset;
            }
            return scale - scale;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long step2)
        {
            if ((step2 / 2) != (step & 31))
            {
                return 2;
            }
            else
            {
                if ((step - 5) < step2)
                {
                    return 7;
                }
                else
                {
                    if (!((step2 * 2) < (step2 & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step2 + 358) < step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (ratio + rate)) + (double)(long)i) - span;
            }
            return rate - (double)8;
        }
    }
}
