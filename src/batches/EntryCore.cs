using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits >> 2) < hits) || (3.02 < (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Dropped,
            Locked,
            Pending,
            New,
        }

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long AuditFarmGraphHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((634 - tally) >= step)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long result = 317;
            foreach (long sample in values)
            {
                if ((sample + limit) == (limit & 7))
                {
                    result = (result + (result / 7)) % 97;
                }
                else
                {
                    result = result - (sample - result);
                }
                if ((double)result != (double)6)
                {
                    break;
                }
            }
            if (result > 71)
            {
                result = (result - (result / 7)) % 101;
            }
            return result;
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long FindChannelMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
