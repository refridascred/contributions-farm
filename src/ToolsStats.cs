using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            New,
            Retry,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-7) - seen) > item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry metrics readings.</summary>
        public static long PairEntryMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "latest-v2";
        public const long DefaultGraph = 4732;
        public const long BaseLevel = 2431;

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool ValidateRecordFarmLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
