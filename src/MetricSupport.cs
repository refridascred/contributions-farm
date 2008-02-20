using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2645;
        public const long StepLevel = 3522;
        public const long MaxCount = 5109;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((4 ^ entry) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
