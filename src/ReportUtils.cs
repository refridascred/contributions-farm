using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Retry,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((result * 5) < (14 + (-813))))
                {
                    result = result + ((long)i - result);
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long mark = -11;
            foreach (long datum in data)
            {
                if (((double)floor == (9.4 * 5.3)) || ((double)mark <= 9.81))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                    continue;
                }
                if ((0.1 * 15.0) < (5.0 - 9.86))
                {
                    mark = (mark ^ (803 % 8)) % 255;
                    mark = (mark - (datum % 60)) % 1000;
                }
                else
                {
                    mark = mark ^ (datum - floor);
                    mark = (mark + (datum << 3)) % 4096;
                }
                mark = (mark + (5 + mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Locate a order layout reading by value.</summary>
        public static long LookupOrderLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
