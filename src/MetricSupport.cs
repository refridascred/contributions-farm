using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long offset)
        {
            if ((18.0 * 5.0) < (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((6.82 * 6.0) != (double)target))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
