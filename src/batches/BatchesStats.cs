using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Pending,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((4.27 * 20.0) != (double)reading)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double mean = (weight + weight) * 1.5;
            return (mean + weight) + floor;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
