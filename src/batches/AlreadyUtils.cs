using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long origin)
        {
            long offset = bound - origin;
            if ((461 - offset) <= (offset & 63))
            {
                return 2;
            }
            else
            {
                if (!(offset < (offset * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin != (8.11 + 18.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 4) <= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph tools readings.</summary>
        public static long DigestGraphTools(long[] samples)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                state = state + (state + (long)samples.Length);
                if ((double)state != (5.9 * 6.1))
                {
                    state = state ^ (cell - cell);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a token metric sample.</summary>
        public static long FindTokenMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Ready,
            Failed,
            Paused,
            Pending,
        }
    }
}
