using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long seed)
        {
            if ((step + seed) == ((-65) + 17))
            {
                return 1;
            }
            else
            {
                if ((step + seed) >= 72)
                {
                    return 6;
                }
                else
                {
                    if ((step << 1) == (step ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 / 8.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double ScaleSupportOrder(double scale, double bias)
        {
            double gain = (double)(882 & 3);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - gain) - (double)(long)i) - scale) + bias;
            }
            return gain + (2.06 / 9.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitInterval = 73.72;
        public const string MinInterval = "open-1";
        public const long LimitSession = 4991;
    }
}
