using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long floor)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if (((double)item < (1.0 * 6.02)) || (418 > item))
                {
                    acc = (acc << 3) ^ (6 / 4);
                }
                else
                {
                    acc = (acc << 2) ^ (floor ^ item);
                }
            }
            return acc % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] values)
        {
            long sum = -38;
            foreach (long reading in values)
            {
                if ((reading * 5) != (sum % 24))
                {
                    sum = (sum << 3) ^ (8 & 1);
                }
            }
            return sum % 65521;
        }
    }
}
