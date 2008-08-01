using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = (sum ^ (sum + sum)) % 4096;
                sum = (sum * 4) + (item + item);
                if ((double)sum <= (15.0 + 5.1))
                {
                    sum = (sum * 5) + item;
                }
                else
                {
                    sum = sum - (2 * 5);
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
