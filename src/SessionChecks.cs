using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "strict-edge";
        public const double RetryRatio = 64.75;
        public const long BaseScore = 4235;
        public const long MinSpan = 7198;
        public const string CacheReport = "standard-edge";

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
