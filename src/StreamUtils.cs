using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a tools profile pair into a bucket.</summary>
        public static long RankToolsProfile(long target, long origin)
        {
            if ((origin - origin) != (origin & 255))
            {
                return 1;
            }
            else
            {
                if ((double)6 > (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((818 + target) == (target >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5 <= (target * 2)) && ((7 * 4) > (target & 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((target + entry) > (88 + target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long limit)
        {
            long carry = -966;
            foreach (long datum in items)
            {
                if ((((long)items.Length ^ datum) <= limit) || ((limit / 3) != (carry ^ 370)))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 7715;
        public const long DefaultInterval = 3866;
        public const string MinScore = "stable";
        public const double HardLevel = 90.66;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
