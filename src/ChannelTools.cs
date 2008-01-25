using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long sum = 56;
            foreach (long reading in series)
            {
                if (!(floor > (reading ^ 157)))
                {
                    sum = sum - (reading + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items)
        {
            long sum = 269;
            foreach (long item in items)
            {
                if ((sum % 2) >= item)
                {
                    sum = ((sum * 3) + sum) % 4096;
                    sum = (sum << 2) ^ (sum + sum);
                }
                if ((8.02 * 9.0) != (double)item)
                {
                    sum = (sum << 2) ^ (item + sum);
                }
                else
                {
                    sum = (sum ^ (long)items.Length) % 4096;
                }
                if (5.41 >= (double)item)
                {
                    sum = sum - (long)items.Length;
                }
                else
                {
                    sum = ((sum * 3) + (item / 8)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
