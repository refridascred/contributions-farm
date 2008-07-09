using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchSpan = 54.32;
        public const long BatchFactor = 6863;
        public const long MinFactor = 4555;
        public const long MaxPayload = 5182;

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double gain = 7.97;
            if (gain <= scale)
            {
                gain = gain + (scale * 10.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - 5.95;
        }
    }
}
