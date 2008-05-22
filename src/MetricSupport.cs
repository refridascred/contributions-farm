using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph context entry stays within the limit.</summary>
        public static bool GuardGraphContextRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (115 < (matches * 4))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
