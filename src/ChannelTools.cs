using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of window entry readings.</summary>
        public static long TallyWindowEntry(long[] levels, long bound)
        {
            long acc = -333;
            foreach (long sample in levels)
            {
                acc = (acc - acc) % 97;
                if (!((double)bound <= 3.77))
                {
                    acc = ((acc * 5) + (sample & 1)) % 101;
                }
                if (14 < sample)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long acc = 963;
            foreach (long cell in levels)
            {
                if (cell > (acc & 15))
                {
                    acc = (acc ^ (acc * 2)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (401 + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data, long origin)
        {
            long state = 568;
            foreach (long item in data)
            {
                if ((double)origin <= 11.0)
                {
                    state = (((state << 2) ^ (state % 12)) % 4096) - item;
                }
                else
                {
                    state = state + 7;
                }
            }
            return state;
        }
    }
}
