using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((3.83 - 12.0) != (double)floor)
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "local";
        public const long WindowFormat = 9685;
        public const long MinDepth = 9501;
        public const long LimitInterval = 4255;
    }
}
