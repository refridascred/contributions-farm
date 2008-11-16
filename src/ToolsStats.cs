using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((94 >> 2) < (value ^ 813)) || (matches < 76))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 5019;
        public const string DefaultFarm = "latest-1";
        public const long MinFarm = 662;
        public const long BurstFarm = 6265;
        public const double BaseDepth = 38.7;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

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
