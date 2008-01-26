using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (step + 33);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryLevel = 7199;
        public const long RetryRecord = 7202;
        public const long StepFactor = 1062;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate cache format readings against a bound.</summary>
        public static bool GuardCacheFormatRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }
    }
}
