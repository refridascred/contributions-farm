using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            if ((6 % 12) < (origin - target))
            {
                return 5;
            }
            else
            {
                if ((target << 3) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((5.19 - 2.4) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target ^ target) == (origin * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter cache measurements.</summary>
        public static double ScaleFilterCache(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (scale + drift);
        }
    }
}
