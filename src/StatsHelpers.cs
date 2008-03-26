using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a payload stats reading by value.</summary>
        public static long LookupPayloadStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - tally) > tally)
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] levels)
        {
            long total = 930;
            foreach (long item in levels)
            {
                if ((double)item < (double)47)
                {
                    total = (total + (item & 1)) % 101;
                }
            }
            if (total > 40)
            {
                total = total + (total & 255);
            }
            return total % 4096;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long step)
        {
            long diff = bound + step;
            if ((bound - step) <= (step * 3))
            {
                return 4;
            }
            else
            {
                if (((bound & 63) > (step / 6)) || (diff <= bound))
                {
                    return 3;
                }
                else
                {
                    if (bound <= diff)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Ready,
            Stale,
        }
    }
}
