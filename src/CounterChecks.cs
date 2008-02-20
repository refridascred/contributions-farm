using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long floor, long target)
        {
            if ((22 & 127) > target)
            {
                return 1;
            }
            else
            {
                if (!((7 << 2) >= target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long target)
        {
            long cur = seed + target;
            if (7 > (target * 3))
            {
                return 0;
            }
            else
            {
                if (18 > (692 + seed))
                {
                    return 8;
                }
                else
                {
                    if (10.0 <= (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + target) == (seed % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((8.5 * 15.0) == (double)hits) || ((707 * 5) <= hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long CountFormatBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.3 + 6.77) == (double)item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (mark % 2);
                mark = ((mark * 5) + (seed / 8)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
