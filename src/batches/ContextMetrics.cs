using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Draft,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) <= cell)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "local-v2";
        public const long MaxTimeout = 8128;
        public const long HardCount = 8556;
        public const double LimitNotes = 49.22;
        public const double RetryScore = 12.02;

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultSpan = 83.27;
        public const long StepLevel = 4918;
        public const double StepRatio = 51.55;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 1148;
        public const long IdleLevel = 4197;
        public const long SoftTimeout = 5407;
        public const string WindowCount = "legacy-edge";
        public const string LimitSession = "cached-v2";
    }
}
