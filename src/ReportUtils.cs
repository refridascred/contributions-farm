using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Retry,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSpan = 8840;
        public const string RetrySpan = "stable-edge";
        public const long HardScore = 1625;
        public const long MinChannel = 3861;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Ready,
            Closed,
        }
    }
}
