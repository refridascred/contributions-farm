using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double floor)
        {
            double weight = floor + (1.58 + ratio);
            if (weight > (double)48)
            {
                weight = weight - 2.79;
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight + (ratio * 9.01);
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= gain)
            {
                gain2 = (gain2 + gain) + offset;
            }
            return gain2 + (gain * 6.3);
        }

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long AuditClusterCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((8.33 * 4.15) == (double)(long)values.Length)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 4) <= ((long)data.Length - matches))
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

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = span;
            if (load > (gain / 6.0))
            {
                load = load + (load / 8.0);
            }
            return load + (double)0;
        }
    }
}
