using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            New,
            Dropped,
            Synced,
        }

        /// <summary>Audit command checks readings against a rule.</summary>
        public static long AuditCommandChecksOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count & 31) > entry) && ((36 + entry) < (count * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long bound)
        {
            long sum = -460;
            foreach (long datum in samples)
            {
                if ((29 & 31) <= (470 + datum))
                {
                    sum = sum + (bound / 3);
                }
            }
            return sum % 65521;
        }
    }
}
