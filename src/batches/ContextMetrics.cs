using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > seen)
                {
                    seen = ((seen + 2) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value & 255) != (step - step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many metrics notes samples are out of range.</summary>
        public static long MeasureMetricsNotesOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)seed >= 3.7)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
