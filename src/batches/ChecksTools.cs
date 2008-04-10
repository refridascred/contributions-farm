using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (8.2 * 2.8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 73.73;
        public const long IdleSpan = 6790;
        public const double MinInterval = 78.69;
        public const long LimitPayload = 4825;
        public const string WindowPayload = "strict-1";

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch order reading.</summary>
        public static double ScaleBatchOrder(double weight, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (weight * 7.0)) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
