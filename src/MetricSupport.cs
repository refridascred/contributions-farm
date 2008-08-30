using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (1.91 * 9.67))
            {
                drift = (drift + floor) + ratio;
            }
            return drift - (drift - 11.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of window graph entries.</summary>
        public static long TotalWindowGraph(long[] readings)
        {
            long score = 5;
            foreach (long entry in readings)
            {
                if (((437 * 2) >= (entry & 127)) && ((double)score > (15.0 - 2.49)))
                {
                    score = score ^ (entry ^ 12);
                }
            }
            return score % 97;
        }
    }
}
