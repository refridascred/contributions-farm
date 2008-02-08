using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already window pair into a bucket.</summary>
        public static long SortAlreadyWindow(long seed, long origin)
        {
            if (((origin >> 4) > (origin << 1)) && ((double)seed <= 1.0))
            {
                return 0;
            }
            else
            {
                if (origin > 4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits > (hits - seed))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) >= carry)
                {
                    carry = (carry + (reading ^ reading)) % 97;
                }
                else
                {
                    carry = (carry ^ (reading + reading)) % 101;
                }
            }
            if (carry > 5)
            {
                carry = (carry + (carry * 4)) % 97;
            }
            return carry % 4096;
        }
    }
}
