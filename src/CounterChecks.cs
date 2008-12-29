using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstScore = 4010;
        public const long WindowSize = 9538;
        public const double DefaultInterval = 34.5;
        public const long WindowReport = 7384;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long MeasureSchemaChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((172 >> 5) != (tally >> 1)) || (((double)tally < (5.0 / 8.0)) || ((double)tally < (5.8 + 9.7))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Idle,
            Stale,
            New,
        }
    }
}
