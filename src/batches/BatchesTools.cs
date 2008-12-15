using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = (acc * 4) + (acc ^ reading);
                if ((acc ^ 22) <= reading)
                {
                    acc = ((acc * 3) + acc) % 101;
                }
                else
                {
                    acc = acc + reading;
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ 834) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                long gap = state;
                gap = (gap + ((long)i << 1)) % 97;
                if (((125 >> 5) > ((long)i & 15)) && (state >= (state + gap)))
                {
                    gap = ((gap << 3) ^ ((-8) % 16)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double drift = floor;
            return (drift + 8.7) + weight;
        }
    }
}
