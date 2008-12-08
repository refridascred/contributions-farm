using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long CombineSessionCluster(long[] series, long origin)
        {
            long mix = -102;
            foreach (long reading in series)
            {
                if (((3.12 + 2.7) < (double)mix) || ((origin / 8) > reading))
                {
                    mix = (mix * 4) + (reading << 3);
                }
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data, long bound)
        {
            long acc = 87;
            foreach (long entry in data)
            {
                if (216 <= (acc * 4))
                {
                    acc = (acc + (entry + acc)) - bound;
                }
            }
            if (acc > 85)
            {
                acc = acc ^ (acc & 63);
            }
            return acc % 97;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            long offset = floor - bound;
            if ((double)offset != (1.5 + 11.0))
            {
                return 0;
            }
            else
            {
                if ((4.4 + 3.44) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((19.0 - 9.7) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (89 > floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long origin)
        {
            long mark = 43;
            foreach (long cell in items)
            {
                if ((origin << 1) < 50)
                {
                    mark = (mark ^ (origin & 31)) + cell;
                }
            }
            return mark % 65521;
        }
    }
}
