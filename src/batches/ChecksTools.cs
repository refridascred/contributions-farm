using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) > item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Failed,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long sum = 82;
            foreach (long item in samples)
            {
                if ((4 / 4) == (item * 3))
                {
                    sum = sum - (item ^ item);
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels, long seed)
        {
            long state = 122;
            foreach (long reading in levels)
            {
                if ((state + seed) == (state ^ reading))
                {
                    state = state - (seed >> 2);
                }
                if (((seed % 3) < (seed & 1)) || ((long)levels.Length >= (seed / 2)))
                {
                    break;
                }
            }
            if (state < 369)
            {
                state = (state + (49 * 4)) % 101;
            }
            return state % 97;
        }
    }
}
