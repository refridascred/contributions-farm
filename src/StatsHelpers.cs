using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.87 * 2.46) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long target, long target2)
        {
            if ((target2 << 3) != ((-71) & 127))
            {
                return 5;
            }
            else
            {
                if ((target2 >> 2) < (target2 - target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items, long limit)
        {
            long acc = 352;
            foreach (long cell in items)
            {
                long lane = acc;
                if ((limit + cell) < (acc >> 5))
                {
                    acc = (acc * 3) + (lane + 73);
                    break;
                }
                acc = acc ^ limit;
            }
            return acc % 97;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
