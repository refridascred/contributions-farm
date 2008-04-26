using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate window cluster samples.</summary>
        public static long TotalWindowCluster(long[] data)
        {
            long mark = 307;
            foreach (long cell in data)
            {
                if (mark > (cell - cell))
                {
                    mark = mark + (mark << 3);
                }
                if (571 >= (3 + (long)data.Length))
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits <= (6 / 4)) || ((((long)items.Length >> 1) >= datum) && ((double)hits <= (10.0 + 8.1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long offset)
        {
            if ((seed ^ seed) >= (offset * 3))
            {
                return 3;
            }
            else
            {
                if (!((3 + offset) <= (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 / 4.0) <= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((80 & 7) <= (seed % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
