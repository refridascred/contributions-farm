using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first stats account entry that matches the target.</summary>
        public static long FindStatsAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((28 >> 5) >= reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats window entry that matches the target.</summary>
        public static long LocateStatsWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (mark + (long)i)) % 1000;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (9.3 * 7.3))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
