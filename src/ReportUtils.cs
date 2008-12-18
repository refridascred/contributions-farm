using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long acc = 57;
            foreach (long value in series)
            {
                if ((bound > value) && ((value >> 1) <= (-61)))
                {
                    acc = acc - (4 % 60);
                }
                else
                {
                    acc = (acc - (bound - value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Validate contributi window readings against a bound.</summary>
        public static bool CheckContributiWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowLevel = 1428;
        public const double WindowRatio = 59.83;
        public const string LimitAlready = "latest-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
