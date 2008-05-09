using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double gain = floor;
            if (gain <= (double)0)
            {
                gain = (gain + (14.0 + 2.52)) + scale;
            }
            else
            {
                gain = gain - (floor * 7.6);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)66) + (double)(long)i;
            }
            return gain - (double)89;
        }

        /// <summary>Match up cache command samples.</summary>
        public static long OverlapCacheCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long target)
        {
            long gap = floor - target;
            if (target <= floor)
            {
                return 7;
            }
            else
            {
                if ((gap * 5) > (gap / 9))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstSize = 62.62;
        public const long DefaultInterval = 2999;
        public const long SoftStats = 4350;
        public const long IdleScore = 6270;
        public const double MinSpan = 81.08;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
