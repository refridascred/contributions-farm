using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Pending,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2429;
        public const string SoftRatio = "standard";
        public const long BatchSize = 1315;
        public const long BurstCluster = 7467;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 2709;
        public const string LimitTools = "local-v2";
        public const long HardTools = 1553;
        public const long StepFactor = 5540;
        public const double MaxCount = 63.41;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Pending,
            Failed,
        }
    }
}
