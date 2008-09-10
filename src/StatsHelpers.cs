using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count & 31) > (count >> 1)))
                {
                    count = ((count + 1) ^ reading) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (168 >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
