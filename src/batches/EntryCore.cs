using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseCount = 2376;
        public const double HardSupport = 75.47;
        public const double BurstCount = 39.93;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 8000;
        public const double BatchCache = 21.14;
        public const double BurstBudget = 72.05;
        public const long IdleCache = 6154;
        public const long DefaultInterval = 9662;

        /// <summary>Rank counter order input into a small class.</summary>
        public static long RankCounterOrder(long floor, long floor2)
        {
            if ((6.22 / 8.0) >= (2.0 * 11.0))
            {
                return 3;
            }
            else
            {
                if ((960 ^ floor2) < (3 << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items, long target)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix + (target % 100)) % 65521) - (long)i) ^ reading;
                    mix = (mix + ((long)items.Length * 5)) % 97;
                }
                mix = mix + (mix & 255);
                if ((double)mix < (8.0 * 0.3))
                {
                    mix = mix ^ (target & 255);
                }
                else
                {
                    mix = (mix ^ (979 >> 2)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
