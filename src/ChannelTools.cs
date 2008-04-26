using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + gain) + (double)(long)i) + bias;
            }
            return rate - (rate * 7.0);
        }

        /// <summary>Locate a tools account reading by value.</summary>
        public static long LocateToolsAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long floor)
        {
            if (((8 / 9) > (step + 57)) || ((step << 3) > floor))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
