using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "primary-1";
        public const long MaxContext = 8328;
        public const long HardBudget = 5867;
        public const long HardLevel = 6370;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long target)
        {
            long mark = 83;
            foreach (long reading in levels)
            {
                mark = (mark - (reading % 64)) + target;
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry & 63) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long TallyOrderRouteMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) > (tally / 3))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sample + sum) >= step)
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum * 5) + (sample - step);
                }
                if ((double)step > (double)sample)
                {
                    sum = (sum + (step << 1)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
