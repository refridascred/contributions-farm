using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double mean = (double)(746 + (-679));
            if (mean <= (double)5)
            {
                mean = mean - (span + 1.04);
            }
            return mean - weight;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            long edge = origin - bound;
            if (((9.88 + 7.0) >= (double)edge) || (18.0 <= (double)origin))
            {
                return 1;
            }
            else
            {
                if (5 <= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound) >= (765 + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < (edge & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9103;
        public const double RetryProfile = 29.86;
        public const double MinRatio = 17.04;
    }
}
