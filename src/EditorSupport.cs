using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long origin)
        {
            long carry = 336;
            foreach (long reading in series)
            {
                if (!((carry % 2) >= (reading / 3)))
                {
                    carry = (carry ^ (carry + origin)) % 255;
                }
                if (((1.65 + 1.0) < (double)origin) && ((double)carry >= (double)3))
                {
                    carry = (carry * 2) + (reading / 9);
                }
                else
                {
                    carry = (carry << 3) ^ (483 * 5);
                }
            }
            if (carry < 34)
            {
                carry = carry - (carry * 3);
            }
            return carry % 1000;
        }

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long TallySessionCommitsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((limit * 5) != (sample & 127)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (double)(long)items.Length)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((7.22 * 4.7) != (double)item) && (631 <= (item - seen)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
