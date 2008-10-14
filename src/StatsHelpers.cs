using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches < (7.27 - 18.0))
                {
                    matches = ((matches + 2) + datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchScore = 40.09;
        public const long BaseRecord = 2297;
        public const double LimitRatio = 43.58;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Synced,
            Draft,
            Ready,
        }
    }
}
