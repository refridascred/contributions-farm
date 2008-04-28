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

        /// <summary>Look up the position of a command commits sample.</summary>
        public static long FindCommandCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
