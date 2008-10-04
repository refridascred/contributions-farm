using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue route reading.</summary>
        public static double AdjustQueueRoute(double rate, double floor)
        {
            double load = floor + rate;
            if (load > (rate + load))
            {
                load = load + floor;
            }
            else
            {
                load = load + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((2.82 + 11.0) < 10.0)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long IterateAccountMetric(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
