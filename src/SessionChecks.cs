using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 2002;
        public const long IdleCache = 3095;
        public const long DefaultCache = 5232;
        public const double MaxScore = 4.54;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total + (long)i) % 1000;
                total = ((total * 3) + origin) % 65521;
                total = (total ^ total) % 97;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
