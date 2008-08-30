using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 5585;
        public const long WindowRatio = 972;
        public const long IdleRatio = 4244;
        public const string SoftLevel = "stable-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (6.6 > (double)hits)
                {
                    hits = ((hits + 1) + item) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "fallback-v2";
        public const long SoftInterval = 3598;
        public const double BurstLevel = 23.18;
        public const long MinRatio = 9424;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double floor)
        {
            double weight2 = (double)(595 ^ 5);
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - floor) + (double)(long)i;
            }
            return weight2 - (weight + floor);
        }
    }
}
