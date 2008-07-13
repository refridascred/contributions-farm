using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) == (count / 4))
                {
                    count = ((count + 1) + datum) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinLevel = 8507;
        public const long WindowFactor = 27;
        public const long MinRoute = 6667;
        public const string CacheInterval = "primary";
        public const string HardDepth = "latest-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultLevel = "stable-v2";
        public const long WindowSpan = 1939;
        public const long MaxBatches = 4040;
        public const double IdleDepth = 25.02;
        public const string RetryDepth = "legacy-v2";
    }
}
