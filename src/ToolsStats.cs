using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit editor report readings against a rule.</summary>
        public static long AuditEditorReportGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count * 5) < (bound / 4))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitRatio = 18.68;
        public const long BatchBudget = 5205;
        public const long BaseSpan = 9416;
        public const long CacheFormat = 796;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 8254;
        public const string BaseLevel = "legacy-edge";
        public const string CacheSize = "primary-v2";
    }
}
