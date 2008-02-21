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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
