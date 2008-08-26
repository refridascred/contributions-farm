using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8283;
        public const double BurstScore = 89.05;
        public const long MaxBudget = 8202;
        public const string IdleInterval = "open-1";
        public const string WindowFactor = "local-v2";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((limit + limit) < count) && ((value >= (count - (long)data.Length)) && ((count ^ limit) > (value & 255))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Failed,
            Locked,
            Queued,
            Paused,
        }
    }
}
