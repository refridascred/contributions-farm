using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long offset)
        {
            if ((offset - floor) <= (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (((596 + floor) > (offset % 3)) || ((offset + floor) > (offset - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 1) != (floor + floor))
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

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long total = 6;
            foreach (long sample in samples)
            {
                if ((sample - bound) < (sample % 24))
                {
                    total = (total << 2) ^ ((-8) + bound);
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = (((anchor * 4) + (anchor / 4)) % 255) ^ reading;
            }
            return anchor % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (tally & 127))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
