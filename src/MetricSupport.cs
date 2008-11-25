using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((3.0 * 7.69) > (double)datum) || (seed <= (datum + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double ratio = (double)(84 ^ 8);
            if (ratio <= gain)
            {
                ratio = (ratio + (ratio * 8.0)) - span;
            }
            else
            {
                ratio = ratio - (ratio * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
