using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long acc = 71;
            foreach (long datum in series)
            {
                if ((datum * 5) > (acc + datum))
                {
                    acc = (acc * 4) + (405 ^ acc);
                }
                else
                {
                    acc = (acc * 5) + (seed >> 4);
                }
            }
            return acc;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double drift = weight + floor;
            return drift - (floor * 7.2);
        }

        /// <summary>Locate a queue account reading by value.</summary>
        public static long LookupQueueAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (149 < (hits - reading))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
