using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels)
        {
            long sum = 85;
            foreach (long item in levels)
            {
                sum = ((sum * 3) + (sum - item)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route commits readings.</summary>
        public static long ScoreRouteCommits(long[] items, long target)
        {
            long total = 35;
            foreach (long item in items)
            {
                if (374 < (long)items.Length)
                {
                    total = (((total << 2) ^ (total - (-4))) % 65521) + item;
                }
            }
            if (total < (-882))
            {
                total = total ^ (6 + target);
            }
            return total % 4096;
        }
    }
}
