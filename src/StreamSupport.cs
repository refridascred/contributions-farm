using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate support farm readings against a bound.</summary>
        public static bool ValidateSupportFarmRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache contributi figure with a bias.</summary>
        public static double ScaleCacheContributi(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias + scale))
            {
                scale = (scale + (double)58) + floor;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + (double)85;
        }
    }
}
