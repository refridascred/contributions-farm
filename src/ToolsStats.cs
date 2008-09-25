using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count payload route pairs that satisfy a relation.</summary>
        public static long ComparePayloadRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first checks commits entry that matches the target.</summary>
        public static long LocateChecksCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryBudget = 5901;
        public const double CacheLayout = 39.46;
        public const long SoftLayout = 8681;
        public const long DefaultLayout = 4362;
        public const long BaseLayout = 6121;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
