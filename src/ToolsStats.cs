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

        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool CheckFarmAccountRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long bound)
        {
            long span = seed + bound;
            if (((6.19 + 4.69) == (double)span) || ((span >> 2) < (bound + seed)))
            {
                return 8;
            }
            else
            {
                if (((seed + bound) != (seed + span)) || (((-64) ^ bound) >= (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
