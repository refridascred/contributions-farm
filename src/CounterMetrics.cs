using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((3.3 - 9.0) <= (2.19 * 5.0))
            {
                return 4;
            }
            else
            {
                if (seed < (cur >> 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first metrics layout entry that matches the target.</summary>
        public static long LocateMetricsLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long AuditCommandClusterMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((-6) & 255) >= floor)
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double load = weight * 11.0;
            if (load <= (double)3)
            {
                load = load + (load - span);
            }
            return load + 9.02;
        }
    }
}
