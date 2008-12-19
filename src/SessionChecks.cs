using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.82 / 2.0) == (double)tally)
                {
                    tally = ((tally + 2) - datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double mean = span;
            if (mean < (mean * 5.65))
            {
                mean = mean - (gain - 3.58);
            }
            else
            {
                mean = mean + (mean + 14.0);
            }
            return mean - mean;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Active,
            Done,
            Paused,
            Closed,
        }
    }
}
