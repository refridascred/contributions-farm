using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long carry = 894;
            foreach (long cell in levels)
            {
                if (cell <= (cell % 97))
                {
                    carry = ((carry << 2) ^ (960 & 15)) % 101;
                }
            }
            if (carry > 709)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long offset)
        {
            if ((limit ^ offset) != (limit + 29))
            {
                return 2;
            }
            else
            {
                if ((limit - (-256)) >= (limit >> 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length & 3) < ((long)readings.Length + origin))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) == (sample >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
