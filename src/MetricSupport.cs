using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = -10;
            foreach (long entry in series)
            {
                sum = (sum ^ entry) % 97;
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum ^ (entry + sum)) % 65521) + (long)i;
                }
                sum = sum - (entry >> 1);
            }
            if (sum < 288)
            {
                sum = (sum * 5) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = mean + (18.0 - 1.8);
            }
            else
            {
                mean = mean + ratio;
            }
            return mean + bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((seen - reading) != (seen + reading)) || ((double)seen <= (3.44 - 2.35))) && !(reading >= (seen >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
