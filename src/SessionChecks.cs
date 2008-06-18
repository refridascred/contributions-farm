using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit editor report readings against a rule.</summary>
        public static long CountEditorReportOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 1) <= origin)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value <= (value * 3)) && (count > (count - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowInterval = 78.13;
        public const string SoftTimeout = "alpha-edge";
        public const long BatchWidth = 1338;
        public const long LimitSupport = 1310;
        public const string BurstSupport = "stable-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "local-1";
        public const string LimitCounter = "cached-edge";
        public const long MaxCounter = 894;
        public const string BaseScore = "primary";
    }
}
