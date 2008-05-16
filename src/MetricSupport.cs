using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long anchor = 4;
            foreach (long sample in series)
            {
                anchor = (anchor << 3) ^ (262 << 3);
                if ((anchor <= (sample % 10)) && ((anchor - anchor) >= sample))
                {
                    anchor = (anchor * 4) + ((-18) & 127);
                    continue;
                }
                if (0.3 > (double)anchor)
                {
                    anchor = (anchor ^ (anchor ^ 474)) % 101;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor + (anchor % 12)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Closed,
            Done,
            Idle,
            Stale,
        }
    }
}
