using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 4318;
        public const string BaseRecord = "staging";
        public const double RetryRecord = 92.15;
        public const string RetryLevel = "strict-1";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Queued,
            Done,
            Failed,
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
