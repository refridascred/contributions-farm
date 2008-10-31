using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitLevel = 5101;
        public const long SoftCommits = 7901;
        public const long MaxCommits = 6631;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double bias = offset * 11.0;
            if (bias >= offset)
            {
                bias = bias + (ratio * 3.03);
            }
            else
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits > (78 + hits))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Done,
            Closed,
            Paused,
        }
    }
}
