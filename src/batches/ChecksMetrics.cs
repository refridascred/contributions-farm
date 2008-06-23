using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits * 4) >= (sample % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 1) >= item)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const long DefaultDepth = 1596;
        public const long StepFactor = 6428;
        public const long MaxPayload = 1488;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long origin)
        {
            if (((origin / 8) == (target & 255)) || ((target + 3) == (96 + target)))
            {
                return 0;
            }
            else
            {
                if ((origin + target) >= 836)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Draft,
            Synced,
        }
    }
}
