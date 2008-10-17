using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor ^ mix) > (floor - 88))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = acc + (acc / 5);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstRatio = 4108;
        public const double BurstEditor = 49.05;
        public const long BurstLevel = 354;
        public const long CacheEditor = 875;
        public const long WindowTimeout = 7708;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long anchor = 18;
            foreach (long reading in data)
            {
                if ((1.0 > (double)(long)data.Length) || (((long)data.Length ^ step) <= step))
                {
                    anchor = (anchor - (reading >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate entry stats samples.</summary>
        public static long ScoreEntryStats(long[] readings)
        {
            long anchor = 2;
            foreach (long item in readings)
            {
                if ((item + anchor) == (item ^ item))
                {
                    anchor = (anchor + (anchor - (-226))) % 101;
                    anchor = (anchor - (364 & 31)) % 97;
                }
                anchor = (anchor + (72 % 100)) % 97;
            }
            return anchor % 1000;
        }
    }
}
