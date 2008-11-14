using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long acc = -433;
            foreach (long value in series)
            {
                if (((double)acc <= (0.58 / 9.0)) || (((-6) + value) == (value / 6)))
                {
                    acc = (acc - ((long)series.Length << 1)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Locate a record schema reading by value.</summary>
        public static long FindRecordSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((993 * 3) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long ClassifyCounterPayload(long step, long floor)
        {
            if ((8.0 * 0.6) < (double)floor)
            {
                return 3;
            }
            else
            {
                if (!((step * 3) <= floor))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double gain = (double)338 - (span * 6.31);
            if (gain <= (4.6 - bias))
            {
                gain = gain + gain;
            }
            return gain - (double)49;
        }
    }
}
