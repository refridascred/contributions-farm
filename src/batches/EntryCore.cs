using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long origin)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((double)origin >= 1.0)
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long count = bound;
                    result = (((result << 2) ^ count) % 101) ^ (long)i2;
                }
                if (!((result / 8) != (result ^ bound)))
                {
                    result = (result + result) % 65521;
                }
                result = (result ^ (bound - (-7))) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long target, long seed)
        {
            if ((target <= 515) || (target > (target - target)))
            {
                return 1;
            }
            else
            {
                if (seed >= 267)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first contributi notes entry that matches the target.</summary>
        public static long LocateContributiNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
