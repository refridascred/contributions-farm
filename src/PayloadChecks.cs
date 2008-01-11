using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4202;
        public const string DefaultSpan = "alpha-1";
        public const long StepQueue = 5649;
        public const string BatchInterval = "open-1";
        public const long DefaultBudget = 2678;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits / 6) <= (sample << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
