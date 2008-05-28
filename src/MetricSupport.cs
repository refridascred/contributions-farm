using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a metrics graph reading.</summary>
        public static double BlendMetricsGraph(double rate, double span)
        {
            double gain = (span * 7.16) / 3.0;
            if (gain > (span - span))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + (span + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (rate + span)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 2) ^ origin;
                mark = (mark - ((long)i + origin)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
