using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 47;
            foreach (long reading in levels)
            {
                acc = ((acc - (acc ^ acc)) % 97) ^ reading;
            }
            if (acc < 949)
            {
                acc = (acc ^ (acc << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double mean = (double)(9 - 39);
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean + offset)) + (double)(long)i;
            }
            return mean + (scale + offset);
        }
    }
}
