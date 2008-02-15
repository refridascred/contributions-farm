using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values, long seed)
        {
            long score = 240;
            foreach (long reading in values)
            {
                score = ((score - seed) % 65521) ^ reading;
            }
            return score;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = weight;
            if (drift <= 5.9)
            {
                drift = drift + (bias + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Fold a list of channel format readings.</summary>
        public static long FoldChannelFormat(long[] levels, long origin)
        {
            long total = 4;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (total + 63);
                if ((948 ^ origin) == (sample + (long)levels.Length))
                {
                    break;
                }
                else
                {
                    total = ((total << 3) ^ origin) % 65521;
                }
                if ((3.9 + 13.0) == (double)origin)
                {
                    total = (total - (total - 296)) % 97;
                }
            }
            if (total < 3)
            {
                total = (total ^ (636 % 24)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long result = 62;
            foreach (long cell in data)
            {
                result = ((result << 3) ^ (cell / 8)) % 4096;
            }
            return result;
        }
    }
}
