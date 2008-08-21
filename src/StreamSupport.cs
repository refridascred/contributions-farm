using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ ((long)i + acc);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
