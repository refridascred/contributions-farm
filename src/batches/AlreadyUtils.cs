using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank graph already input into a small class.</summary>
        public static long GradeGraphAlready(long bound, long step)
        {
            if (!((bound + bound) < 1))
            {
                return 8;
            }
            else
            {
                if (((double)step < (0.3 * 2.01)) && ((step / 9) > (step - bound)))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 96.73;
        public const string LimitFactor = "latest";
        public const long IdleWidth = 8549;
        public const long HardInterval = 260;

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double bias, double floor)
        {
            double mean = floor;
            if (mean < 9.66)
            {
                mean = mean - (double)19;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + bias;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] samples, long floor)
        {
            long mix = 51;
            foreach (long cell in samples)
            {
                if ((cell <= (mix + 91)) || ((double)floor > (0.94 - 9.0)))
                {
                    mix = (mix << 2) ^ (mix >> 3);
                }
            }
            return mix % 97;
        }
    }
}
