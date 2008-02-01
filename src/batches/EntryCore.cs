using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 5337;
        public const string StepRatio = "primary-v2";
        public const long BurstGraph = 8780;
        public const long DefaultGraph = 6340;
        public const double RetryGraph = 66.85;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSize = 1599;
        public const long WindowCount = 4426;
        public const long BaseRoute = 6484;
        public const double DefaultRoute = 24.73;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long origin)
        {
            long next = seed + origin;
            if (((origin + next) == (17 >> 4)) || ((double)next <= (3.11 * 2.43)))
            {
                return 8;
            }
            else
            {
                if ((7 & 3) != (next * 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double gain = floor;
            if (gain <= (gain * 3.0))
            {
                gain = (gain - (floor * 8.0)) - scale;
            }
            return gain + (double)447;
        }
    }
}
