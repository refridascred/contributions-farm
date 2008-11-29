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

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - 0.23) + (double)(long)i) - bias;
            }
            return ratio - ratio;
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
