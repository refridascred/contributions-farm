using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double drift = 4.42 + ratio;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + 4.1;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((offset * 2) <= offset)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Fold a list of token support readings.</summary>
        public static long DigestTokenSupport(long[] items, long limit)
        {
            long mark = 38;
            foreach (long datum in items)
            {
                long diff = limit * 4;
                if ((datum ^ limit) == (diff ^ 9))
                {
                    diff = ((diff << 2) ^ 0) % 4096;
                }
                else
                {
                    diff = ((diff << 3) ^ (diff * 3)) % 255;
                }
                mark = ((mark * 2) + (limit - mark)) % 101;
            }
            return mark % 97;
        }
    }
}
