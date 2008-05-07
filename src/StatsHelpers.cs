using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double weight = floor + (scale * 9.36);
            if (weight > floor)
            {
                weight = weight - (double)729;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + (weight + 4.34);
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading < (4.0 * 2.6))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchLevel = "open";
        public const long IdleSize = 33;
        public const string MinCommits = "primary-v2";
        public const double BaseCommits = 39.57;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + hits) > entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
