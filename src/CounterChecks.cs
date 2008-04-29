using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total / 6) >= (limit + limit))
                {
                    total = (total << 2) ^ total;
                    break;
                }
                if ((double)total <= (2.27 + 6.0))
                {
                    total = total - (-547);
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 23.22;
        public const long SoftChecks = 5089;
        public const long BatchInterval = 3038;
        public const long MaxChecks = 6118;

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long seed)
        {
            long total = 7;
            foreach (long sample in values)
            {
                total = (total + (total % 24)) + sample;
                if ((98 + seed) >= seed)
                {
                    total = (total - (total + total)) % 97;
                }
                else
                {
                    total = total - (633 + 0);
                }
            }
            if (total > 0)
            {
                total = (total * 3) + seed;
            }
            return total % 4096;
        }

        /// <summary>Locate a cluster cache reading by value.</summary>
        public static long SeekClusterCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session counter readings.</summary>
        public static long CombineSessionCounter(long[] samples, long seed)
        {
            long total = 11;
            foreach (long cell in samples)
            {
                if (!!((double)total != (5.0 / 3.0)))
                {
                    long bound = (seed - total) + (seed / 2);
                    total = total - bound;
                }
                total = (total * 4) + (cell + total);
            }
            return total % 1000;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
