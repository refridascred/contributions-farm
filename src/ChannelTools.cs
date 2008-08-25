using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double bias2 = (double)5 - (double)869;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + 9.75) + (double)(long)i) + gain;
            }
            return bias2 + bias;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry % 100) != (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long DigestProfileCounter(long[] readings)
        {
            long carry = 40;
            foreach (long entry in readings)
            {
                if ((780 / 2) != ((long)readings.Length * 3))
                {
                    continue;
                }
                carry = ((carry ^ 8) % 65521) - entry;
            }
            return carry;
        }
    }
}
