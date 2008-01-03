using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long seed)
        {
            if (((seed >> 5) <= ((-7) + seed)) && ((double)origin > 5.53))
            {
                return 1;
            }
            else
            {
                if (seed > (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((1 - origin) < (seed & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin >= (2.3 + 7.5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (bias2 + bias2))
            {
                scale = scale - (double)7;
            }
            return scale + (scale + bias);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Dropped,
            Draft,
        }
    }
}
