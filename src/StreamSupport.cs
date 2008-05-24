using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings, long target)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                acc = ((((acc << 2) ^ 3) % 101) - entry) - target;
            }
            return acc % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowScore = "fallback-v2";
        public const long MaxTimeout = 8958;
        public const long StepSupport = 3013;
        public const double BaseSupport = 28.64;
        public const long CacheSupport = 4351;
    }
}
