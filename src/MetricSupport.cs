using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((122 + hits) >= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double mean = weight;
            return (mean + 9.61) + span;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Active,
            New,
        }
    }
}
