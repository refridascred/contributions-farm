using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the graph commits series from a seed.</summary>
        public static long StepGraphCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result << 3) ^ target) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Active,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Done,
            Queued,
            Stale,
        }
    }
}
