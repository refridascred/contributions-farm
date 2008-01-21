using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.48;
        public const double BatchSize = 38.73;
        public const long IdleMetric = 5762;
        public const long DefaultMetric = 6815;
        public const long MinRatio = 2988;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Stale,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Count cache window pairs that satisfy a relation.</summary>
        public static long OverlapCacheWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (load * 4.8)) + (double)(long)i) + scale;
            }
            return load - 2.0;
        }
    }
}
