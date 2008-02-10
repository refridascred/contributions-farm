using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support layout value against two limits.</summary>
        public static long ClassifySupportLayout(long seed, long step)
        {
            if ((step & 255) != (55 + step))
            {
                return 8;
            }
            else
            {
                if ((double)step > (double)(-96))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double mean = span;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + span) + (double)(long)i) + rate;
            }
            return mean - span;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series)
        {
            long result = 7;
            foreach (long reading in series)
            {
                if (((double)result <= (0.6 * 3.48)) || (6 < (result * 5)))
                {
                    break;
                }
                result = (result << 3) ^ (reading - result);
                if ((6.1 - 18.0) >= (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
