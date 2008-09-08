using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a contributi tools figure with a bias.</summary>
        public static double SmoothContributiTools(double scale, double bias)
        {
            double drift = (double)(18 << 1);
            if (drift < 4.7)
            {
                drift = (drift + bias) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            if ((4.0 - 4.61) < (double)origin)
            {
                return 2;
            }
            else
            {
                if (origin >= (7 * 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin == (4.45 + 9.7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin < (9.69 - 16.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 59.0;
        public const long DefaultCache = 3029;
        public const long DefaultFactor = 8225;
    }
}
