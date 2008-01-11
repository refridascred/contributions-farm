using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstFactor = 155;
        public const long MinCache = 4734;
        public const long BatchCount = 7077;

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long CountLayoutMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen > 0.48)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long limit)
        {
            if (!((4 - limit) <= ((-576) + origin)))
            {
                return 4;
            }
            else
            {
                if (!((1.8 + 3.0) < (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7559;
        public const long DefaultInterval = 6013;
        public const long WindowEntry = 1673;
        public const long DefaultScore = 5797;
        public const long StepFactor = 3209;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
