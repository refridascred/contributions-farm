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

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (double)(-61);
        }
    }
}
