using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long total = 30;
            foreach (long datum in readings)
            {
                total = ((total * 2) + datum) % 4096;
                total = total - (total ^ total);
            }
            if (total < 324)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long step)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total ^ (entry % 97)) % 1000) - step;
            }
            return total;
        }
    }
}
