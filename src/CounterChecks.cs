using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
            public bool Limit { get; set; }
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
