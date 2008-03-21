using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long bound)
        {
            long anchor = -823;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + (anchor * 2)) + cell) + bound;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 2) ^ (3 >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Locked,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }
    }
}
