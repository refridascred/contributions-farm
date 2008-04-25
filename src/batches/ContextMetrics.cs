using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a githubfarm route figure with a bias.</summary>
        public static double ScaleGithubfarmRoute(double weight, double bias)
        {
            double scale = (double)171;
            if (scale >= (double)(-200))
            {
                scale = (scale - bias) + weight;
            }
            return scale - 20.0;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (double)964)
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (floor * 9.39)) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Rank stream tools input into a small class.</summary>
        public static long GradeStreamTools(long floor, long step)
        {
            long step2 = floor + step;
            if (floor <= (step2 / 5))
            {
                return 3;
            }
            else
            {
                if (step2 >= (step2 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ 9) < (step2 + step2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((75 - step) >= 0)
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

        /// <summary>Blend two contributi notes measurements.</summary>
        public static double SmoothContributiNotes(double gain, double bias)
        {
            double weight = gain;
            if (weight > (double)9)
            {
                weight = weight - (bias * 0.2);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)52) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
