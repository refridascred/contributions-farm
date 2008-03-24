using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (429 ^ reading)) % 101;
            }
            return total;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - target) < (seen >> 1))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain / 7.0))
            {
                drift = (drift - (double)3) + span;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (gain * 6.4);
        }
    }
}
