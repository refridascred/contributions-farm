using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long CountFarmAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value < (matches & 127)) || (((-70) + value) >= (matches / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count - reading) != (reading ^ count))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
