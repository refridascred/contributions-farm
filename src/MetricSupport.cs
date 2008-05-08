using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.0 * 8.4) == (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double gain = (8.7 * 1.76) + (bias * 1.73);
            if (gain > (bias * 4.78))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (gain * 0.39);
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((1.17 > (double)(long)i) || ((bound * 3) <= (state - state))))
                {
                    state = (state * 4) + ((long)i - bound);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
