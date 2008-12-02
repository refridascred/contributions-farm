using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long origin)
        {
            long mark = 88;
            foreach (long reading in items)
            {
                long cur = 509 ^ ((-3) * 3);
                if (((reading - origin) <= mark) && ((double)(long)items.Length != (1.45 / 8.0)))
                {
                    mark = (mark * 3) + (origin + cur);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + cur)) % 65521;
                }
                if (reading > (43 - origin))
                {
                    mark = (mark - (mark & 15)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine tools cache values into a single score.</summary>
        public static long TallyToolsCache(long[] levels)
        {
            long total = -4;
            foreach (long item in levels)
            {
                total = (total + (item + total)) % 255;
            }
            if (total < 793)
            {
                total = ((total * 2) + (715 % 2)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a route stream pair into a bucket.</summary>
        public static long GradeRouteStream(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((floor << 1) >= offset)
            {
                return 7;
            }
            else
            {
                if (((offset & 255) < (offset * 5)) && ((3.0 + 7.0) == (double)delta))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 8355;
        public const long SoftCommand = 3370;
        public const long HardBudget = 2753;
        public const long IdleCommand = 9919;
        public const string IdleScore = "fallback-v2";
    }
}
