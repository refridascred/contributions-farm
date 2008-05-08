using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many account route samples are out of range.</summary>
        public static long TallyAccountRouteMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length < (9.16 / 3.0))
                {
                    hits = ((hits + 1) + datum) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Stale,
            New,
            Queued,
            Retry,
        }

        /// <summary>Classify a order already pair into a bucket.</summary>
        public static long BucketOrderAlready(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((double)slot >= (8.4 + 13.0))
            {
                return 1;
            }
            else
            {
                if ((origin2 > 940) || ((slot % 97) > 179))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + 4) >= origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((642 << 3) >= (slot ^ origin2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry window readings.</summary>
        public static long CompareEntryWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long bound)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (state ^ (bound << 3)) % 101;
                if (((cell + bound) > 113) && (70 < (state << 3)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
