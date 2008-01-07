using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the window already series from a seed.</summary>
        public static long SeriesWindowAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i == (target & 15)) || ((target << 2) < (state - state)))
                {
                    state = ((state << 2) ^ target) % 1000;
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long CombineFormatSession(long[] items)
        {
            long carry = 665;
            foreach (long item in items)
            {
                if ((carry + (-1)) >= (carry << 3))
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
                else
                {
                    carry = carry ^ (carry & 15);
                }
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Draft,
            Paused,
            Queued,
            New,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long bound)
        {
            long lane = origin - bound;
            if (((lane >> 4) <= 717) && ((37 - 0) > origin))
            {
                return 1;
            }
            else
            {
                if ((bound + origin) <= (bound ^ origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
