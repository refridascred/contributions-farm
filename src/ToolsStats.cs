using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinSpan = "latest";
        public const long HardRecord = 2755;
        public const long MinRecord = 9699;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                sum = ((sum + (sum & 31)) % 4096) ^ datum;
            }
            if (sum < 449)
            {
                sum = (sum + (sum - sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSpan = 1513;
        public const long WindowSize = 4094;
        public const string BaseGithubfarm = "fallback-1";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double ratio2 = (ratio - offset) + 5.54;
            if (ratio2 > 2.3)
            {
                ratio2 = ratio2 - 7.0;
            }
            return ratio2 + 9.5;
        }
    }
}
