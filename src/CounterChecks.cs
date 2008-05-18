using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 4956;
        public const string MaxLayout = "staging-v2";
        public const long DefaultLayout = 1248;

        /// <summary>Audit counter window readings against a rule.</summary>
        public static long MeasureCounterWindowGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((bound & 15) < 49)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((tally << 2) < (reading & 15)) || ((floor * 2) > (tally + tally))) || ((tally >> 3) < floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (782 > (matches + sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
