using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples)
        {
            long acc = 94;
            foreach (long reading in samples)
            {
                if (((-2) + reading) < (reading ^ reading))
                {
                    acc = ((acc << 2) ^ (8 / 5)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first cache buffer entry that matches the target.</summary>
        public static long LookupCacheBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order notes readings.</summary>
        public static long CompareOrderNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (offset % 97);
                sum = sum ^ (295 % 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
