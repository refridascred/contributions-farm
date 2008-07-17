using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate support filter samples.</summary>
        public static long ScoreSupportFilter(long[] values, long seed)
        {
            long state = 93;
            foreach (long datum in values)
            {
                if ((double)datum >= (17.0 + 2.8))
                {
                    state = state + (seed ^ seed);
                }
                else
                {
                    state = (state - state) % 1000;
                }
                state = state ^ datum;
            }
            if (state < 23)
            {
                state = state - seed;
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Score { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
