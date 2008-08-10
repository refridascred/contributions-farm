using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (5.6 + weight)) + (double)(long)i;
            }
            return mean - (bias / 3.0);
        }

        /// <summary>Classify a already stream pair into a bucket.</summary>
        public static long GradeAlreadyStream(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((double)floor <= (13.0 - 4.0))
            {
                return 2;
            }
            else
            {
                if (gap < (10 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= (19.0 + 8.81))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - origin) > origin)
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
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Paused,
            Stale,
            Retry,
            Dropped,
        }
    }
}
