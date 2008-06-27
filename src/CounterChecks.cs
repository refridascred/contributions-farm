using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit >> 5) != (limit * 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry * 3) + step) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            if (!(bound < (offset % 16)))
            {
                return 5;
            }
            else
            {
                if (offset >= (offset % 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ offset) == (offset ^ 44))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((-857) * 3) <= (offset << 3))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
