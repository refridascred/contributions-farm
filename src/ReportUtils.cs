using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "legacy";
        public const long RetrySession = 7425;
        public const double RetryBudget = 40.75;
        public const long IdleSession = 9291;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Synced,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSpan = "stable";
        public const long DefaultCount = 5182;
        public const long WindowInterval = 1929;
        public const long RetryInterval = 8247;
        public const long MinFactor = 4653;
    }
}
