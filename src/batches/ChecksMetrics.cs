using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double gain = (double)(78 * 4);
            if (gain <= gain)
            {
                gain = gain + (gain / 7.0);
            }
            else
            {
                gain = gain + span;
            }
            return gain - bias;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Retry,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Pending,
            New,
            Failed,
        }
    }
}
