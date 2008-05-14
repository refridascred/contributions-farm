using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > bound)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((seed + diff) >= (seed >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) < seed)
                {
                    return 1;
                }
                else
                {
                    if (!((seed << 1) == (seed * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit <= (diff >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels)
        {
            long mark = 5;
            foreach (long value in levels)
            {
                mark = (mark * 2) + (mark * 2);
                mark = mark + (mark & 31);
                if ((value << 2) != (mark & 255))
                {
                    break;
                }
            }
            if (mark > 946)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
