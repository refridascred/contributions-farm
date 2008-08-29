using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = ((result ^ (10 >> 2)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 4227;
        public const string IdleCount = "local-1";
        public const long BatchScore = 1503;
        public const long BaseRoute = 113;

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long TallyMetricFarmOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ (long)levels.Length) == (hits ^ 859))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
