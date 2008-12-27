using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) >= origin)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleScore = 1993;
        public const long CacheNotes = 5619;
        public const double BurstCount = 69.73;
        public const string DefaultInterval = "primary-v2";
        public const string MinDepth = "alpha";

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
