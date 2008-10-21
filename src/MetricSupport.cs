using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if ((bound ^ bound) >= step)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (3.8 / 9.0)) && ((step - 53) >= step))
                {
                    return 8;
                }
                else
                {
                    if (((double)step <= (6.0 * 3.6)) && ((bound + bound) >= (334 + step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long DeriveContributiRoute(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                if (!!((mix + 23) >= mix))
                {
                    mix = (mix * 2) + (target >> 5);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double scale, double span)
        {
            double mean = span;
            if (mean >= scale)
            {
                mean = mean - (span - mean);
            }
            else
            {
                mean = mean - (double)93;
            }
            return mean + (double)705;
        }
    }
}
