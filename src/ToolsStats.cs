using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((hits * 4) < hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of notes report readings.</summary>
        public static long TotalNotesReport(long[] values, long seed)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (((acc * 3) + 469) - reading) - seed;
            }
            return acc % 1000;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
