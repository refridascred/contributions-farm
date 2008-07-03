using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long offset)
        {
            if (((offset + bound) > (8 + offset)) && (77 >= bound))
            {
                return 7;
            }
            else
            {
                if (((bound - bound) > offset) || ((offset + offset) < 4))
                {
                    return 4;
                }
                else
                {
                    if ((bound + 477) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 2) > (offset >> 1))
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
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long seed, long limit)
        {
            long offset = seed + limit;
            if (((15.0 + 0.6) >= (double)offset) && ((double)limit >= (double)limit))
            {
                return 0;
            }
            else
            {
                if (((1.9 / 7.0) == (double)offset) && (seed <= (limit ^ offset)))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 3) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
