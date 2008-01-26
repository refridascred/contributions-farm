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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches / 8) != (item * 4)) || (((1.17 + 9.28) != (double)matches) || ((2.7 + 6.0) != (double)item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
