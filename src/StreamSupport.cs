using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                long bound2 = (bound + total) * 4;
                if (!((bound >> 4) != (bound2 % 24)))
                {
                    total = (total << 3) ^ (bound2 / 3);
                    bound2 = ((bound2 << 2) ^ (bound2 << 1)) % 4096;
                }
                if (total < bound2)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long total = 12;
            foreach (long value in series)
            {
                total = (((total * 3) + (total >> 5)) % 97) - value;
                if (((long)series.Length % 10) == (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two notes buffer measurements.</summary>
        public static double ScaleNotesBuffer(double rate, double bias)
        {
            double gain = bias * 5.41;
            if (gain > rate)
            {
                gain = gain + (gain - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (rate * 1.5)) + (double)(long)i;
            }
            return gain + (double)8;
        }
    }
}
