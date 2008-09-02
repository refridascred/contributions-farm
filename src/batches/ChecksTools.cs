using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload stats counter forward.</summary>
        public static long SeriesPayloadStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (sum + sum)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum ^ (seed + seed)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mix = 996;
            foreach (long entry in readings)
            {
                mix = (((mix * 5) + mix) % 255) + entry;
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double mean = offset + (offset / 6.0);
            if (mean > (mean - gain))
            {
                mean = mean - mean;
            }
            return mean + gain;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
