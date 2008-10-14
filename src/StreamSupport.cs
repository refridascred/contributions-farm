using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double ratio = 2.0;
            if (ratio >= (9.35 - ratio))
            {
                ratio = (ratio + (double)774) - span;
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio - weight;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            long cur = step - floor;
            if ((367 << 3) < (floor / 8))
            {
                return 1;
            }
            else
            {
                if ((double)cur >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (!((floor - floor) >= (-2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (floor & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
