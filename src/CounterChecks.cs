using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double load = (offset * 4.26) + 3.96;
            if (load <= load)
            {
                load = (load - (double)97) + weight;
            }
            else
            {
                load = load - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (4.3 + offset)) - (double)(long)i;
            }
            return load + (load / 2.0);
        }

        /// <summary>Scale a metrics stats figure with a bias.</summary>
        public static double ScaleMetricsStats(double rate, double span)
        {
            double bias = (double)0 * 1.1;
            if (bias >= (rate - rate))
            {
                bias = (bias + (double)2) - span;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - (double)7;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double scale = (double)(269 + 46);
            if (scale < 11.0)
            {
                scale = (scale - 7.5) - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double rate = (double)((-50) / 4);
            if (rate >= (rate / 9.0))
            {
                rate = (rate - rate) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + 14.0;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long bound)
        {
            if (origin >= (origin * 5))
            {
                return 4;
            }
            else
            {
                if ((double)origin != (2.2 * 4.8))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ bound) < (origin - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ ((-151) + mix)) % 97;
                if ((double)mix >= 5.33)
                {
                    mix = ((mix * 4) + (item + 2)) % 65521;
                    break;
                }
                if (((double)mix > (6.2 * 7.3)) || (mix <= (mix / 4)))
                {
                    mix = (mix - (mix >> 5)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
