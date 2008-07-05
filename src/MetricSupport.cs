using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a channel cluster pair into a bucket.</summary>
        public static long GradeChannelCluster(long origin, long origin2)
        {
            if ((230 / 7) == (origin2 + origin))
            {
                return 6;
            }
            else
            {
                if (0 <= origin2)
                {
                    return 3;
                }
                else
                {
                    if (!((origin2 + origin2) < (origin - origin2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin2 + origin) >= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double load = span;
            if (load >= (double)5)
            {
                load = load - (load * 2.6);
            }
            else
            {
                load = load - span;
            }
            return load + gain;
        }

        /// <summary>Check that every support window entry stays within the limit.</summary>
        public static bool VerifySupportWindowRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
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
