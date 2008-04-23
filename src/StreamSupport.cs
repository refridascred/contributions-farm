using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((target << 1) >= (8 + hits)) && (((4.3 * 2.66) == (double)target) && ((7.14 + 3.61) <= (double)hits)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
