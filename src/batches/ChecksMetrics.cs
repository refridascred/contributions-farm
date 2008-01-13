using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Closed,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)limit != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 5) + (sum + 299);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools token pair into a bucket.</summary>
        public static long ClassifyToolsToken(long limit, long bound)
        {
            long next = limit ^ bound;
            if ((double)next > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit >> 4) < bound)
                {
                    return 5;
                }
                else
                {
                    if ((next + limit) < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 + 6.22) >= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinRatio = 32.03;
        public const long CacheOrder = 4040;
        public const long LimitBudget = 6190;
    }
}
