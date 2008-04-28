using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double bias2 = bias / 6.0;
            if (bias2 < (bias2 * 5.0))
            {
                bias2 = bias2 - (span / 7.0);
            }
            return bias2 - bias;
        }

        /// <summary>Locate a already payload reading by value.</summary>
        public static long LocateAlreadyPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
