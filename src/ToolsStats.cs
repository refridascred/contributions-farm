using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 5019;
        public const string DefaultFarm = "latest-1";
        public const long MinFarm = 662;
        public const long BurstFarm = 6265;
        public const double BaseDepth = 38.7;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardRatio = 8913;
        public const double BatchTimeout = 10.37;
        public const long HardContext = 8176;
        public const double StepSpan = 63.24;
        public const long DefaultContext = 403;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (result + result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a route entry reading by value.</summary>
        public static long SeekRouteEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
