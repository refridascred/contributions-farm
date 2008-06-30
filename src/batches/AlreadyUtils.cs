using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "cached-v2";
        public const string BaseQueue = "fallback";
        public const double IdleQueue = 95.65;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 9913;
        public const long MaxScore = 2755;
        public const string LimitSpan = "staging-v2";
    }
}
