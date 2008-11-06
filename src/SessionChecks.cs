using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 976;
        public const long WindowSpan = 3444;
        public const long DefaultSize = 8539;
        public const long StepLevel = 3072;
        public const long HardTimeout = 2877;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheFactor = 6652;
        public const string BaseSize = "stable-1";
        public const long LimitProfile = 3513;
        public const double MinProfile = 60.52;

        /// <summary>Accumulate graph cache samples.</summary>
        public static long DigestGraphCache(long[] readings)
        {
            long mark = 48;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ mark) % 97) - sample;
            }
            return mark;
        }
    }
}
