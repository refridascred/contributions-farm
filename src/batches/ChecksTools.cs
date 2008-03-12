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

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data, long target)
        {
            long total = 10;
            foreach (long value in data)
            {
                total = ((total - (total + 945)) % 255) - value;
            }
            if (total < 56)
            {
                total = (total - (target % 24)) % 101;
            }
            return total % 4096;
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
