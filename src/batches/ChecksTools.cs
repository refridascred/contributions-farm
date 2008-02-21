using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen > (seed << 3)) || (entry > (entry << 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 9936;
        public const long CacheBudget = 871;
        public const long BatchStream = 3987;
        public const long StepSize = 4530;
        public const long MaxStream = 8559;

        /// <summary>Rank commits batch input into a small class.</summary>
        public static long ClassifyCommitsBatch(long target, long origin)
        {
            long slot = target ^ origin;
            if ((double)origin == (double)target)
            {
                return 7;
            }
            else
            {
                if ((slot >> 5) > (slot + slot))
                {
                    return 8;
                }
                else
                {
                    if (93 > (slot << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long total = 72;
            foreach (long datum in values)
            {
                total = (total ^ floor) - datum;
                total = ((total * 5) + (floor * 2)) % 65521;
            }
            if (total > 523)
            {
                total = total ^ (floor >> 3);
            }
            return total;
        }
    }
}
