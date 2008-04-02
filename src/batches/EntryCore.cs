using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchLevel = 4705;
        public const double WindowBudget = 48.29;
        public const long RetryRoute = 9339;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout profile reading.</summary>
        public static double SmoothLayoutProfile(double weight, double floor)
        {
            double weight2 = 5.1;
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (weight / 9.0)) + (double)(long)i;
            }
            return weight2 - (floor / 6.0);
        }

        /// <summary>Blend two route context measurements.</summary>
        public static double AdjustRouteContext(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (9.4 * 6.3))
            {
                scale2 = scale2 - (scale2 + scale2);
            }
            else
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 + (scale2 * 5.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
