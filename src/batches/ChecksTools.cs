using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
