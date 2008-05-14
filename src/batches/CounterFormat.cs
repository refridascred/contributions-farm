using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the contributi notes series from a seed.</summary>
        public static long DeriveContributiNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next cluster counter value from a seed.</summary>
        public static long SeriesClusterCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((result % 97) < (13 << 1)))
                {
                    result = (result - offset) % 255;
                }
                long delta = 6;
                if (!(((1 / 3) != (delta + (long)i)) && ((delta << 2) >= (delta << 3))))
                {
                    delta = (delta << 3) ^ (offset << 3);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double rate = (double)(171 / 9);
            if (rate <= 14.0)
            {
                rate = (rate + (2.1 + rate)) - offset;
            }
            return rate - (gain - rate);
        }
    }
}
