using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long DeriveStatsGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                if ((mark - mark) > (long)i)
                {
                    mark = mark + (mark ^ (long)i);
                }
                mark = (mark ^ (mark ^ step)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double rate, double offset)
        {
            double scale = 13.0;
            if (scale >= offset)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale - (rate / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((13.0 / 9.0) <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long seed)
        {
            long offset = origin + seed;
            if ((seed + seed) != (offset >> 1))
            {
                return 0;
            }
            else
            {
                if (seed <= 145)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) != (seed ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((18.0 - 6.6) >= (double)datum)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
