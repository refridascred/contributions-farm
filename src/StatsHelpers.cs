using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long seed)
        {
            if (((double)offset > 2.0) && ((offset + seed) >= seed))
            {
                return 6;
            }
            else
            {
                if ((9.0 / 2.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((4 + seed) >= (offset + 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-4) >= seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] readings, long floor)
        {
            long state = 549;
            foreach (long datum in readings)
            {
                state = state - datum;
                if (((-90) * 4) < ((long)readings.Length / 2))
                {
                    state = state ^ (floor / 7);
                }
                else
                {
                    state = ((state << 3) ^ (6 - floor)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
