using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Draft,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum <= ((long)values.Length << 1)) && (matches >= (65 / 7)))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
