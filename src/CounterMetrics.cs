using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long limit)
        {
            long lane = origin + limit;
            if (lane > origin)
            {
                return 1;
            }
            else
            {
                if ((limit * 3) > limit)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 801) < (218 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= (4.77 - 3.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (seed > (datum + 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
