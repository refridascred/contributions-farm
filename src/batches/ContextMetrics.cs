using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if ((double)6 >= (double)entry)
                {
                    carry = (carry - (carry % 5)) + seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 5) <= (hits + 10)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
