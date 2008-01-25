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

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items, long target)
        {
            long sum = -78;
            foreach (long item in items)
            {
                sum = sum - (item ^ item);
            }
            if (sum < 5)
            {
                sum = (sum * 5) + (target & 31);
            }
            return sum;
        }
    }
}
