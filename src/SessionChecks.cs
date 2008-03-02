using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2452;
        public const double SoftScore = 3.86;
        public const string MinSupport = "staging-v2";
        public const long MinDepth = 5993;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Failed,
            Done,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample <= (9 ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
