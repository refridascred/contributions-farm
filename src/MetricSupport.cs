using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two account checks measurements.</summary>
        public static double SmoothAccountChecks(double gain, double bias)
        {
            double load = bias;
            if (load < (gain + load))
            {
                load = load - (gain - gain);
            }
            return load - (load / 4.0);
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double gain = span - (5.4 + ratio);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (9.1 + span)) + (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 84;
            foreach (long datum in data)
            {
                if ((20.0 + 2.0) > (double)anchor)
                {
                    anchor = ((anchor * 5) + (datum + 68)) % 4096;
                }
            }
            if (anchor < 243)
            {
                anchor = anchor ^ (anchor ^ anchor);
            }
            return anchor % 97;
        }
    }
}
