using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            long diff = offset - origin;
            if (((-58) - offset) >= (origin - 90))
            {
                return 2;
            }
            else
            {
                if (origin >= (diff & 15))
                {
                    return 8;
                }
                else
                {
                    if (8.2 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
