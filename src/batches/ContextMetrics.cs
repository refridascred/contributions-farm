using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long MeasureContributiChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (matches << 2))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter stats value from a seed.</summary>
        public static long IterateFilterStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - offset;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 7082;
        public const long CacheSchema = 5297;
        public const long BurstWidth = 6351;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            New,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
