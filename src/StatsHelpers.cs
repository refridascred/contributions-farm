using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + hits) <= (hits + 797))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
