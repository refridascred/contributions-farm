using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double rate = span;
            if (rate < bias)
            {
                rate = rate + 9.16;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (2.44 - span)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double load = (double)((-254) ^ 706);
            if (load <= 2.0)
            {
                load = (load - (double)840) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)(-665)) + (double)(long)i;
            }
            return load + (span * 9.0);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((829 ^ limit) != (sample + limit)) || ((limit >> 5) >= (sample >> 4))) && ((double)limit > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
