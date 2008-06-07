using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long SortLayoutChecks(long seed, long bound)
        {
            if ((bound + bound) != (bound + 65))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ bound) < (bound * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > (bound ^ bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command route measurements.</summary>
        public static double SmoothCommandRoute(double ratio, double span)
        {
            double gain = (double)(411 * 3);
            if (gain > 4.8)
            {
                gain = ((gain + gain) - ratio) - span;
            }
            else
            {
                gain = gain + (double)267;
            }
            return gain - (gain * 2.67);
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 5) + (limit / 2);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
