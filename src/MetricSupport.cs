using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value >> 4) < value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache checks reading.</summary>
        public static double AdjustCacheChecks(double gain, double floor)
        {
            double bias = (double)150 + (double)(-42);
            if (bias < (double)2)
            {
                bias = (bias - (bias / 4.0)) - gain;
            }
            else
            {
                bias = bias + (2.73 / 4.0);
            }
            return bias - (floor - 1.9);
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
