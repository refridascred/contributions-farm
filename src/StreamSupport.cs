using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a commits notes counter forward.</summary>
        public static long StepCommitsNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark + (long)i) % 101;
                if ((double)bound <= (3.8 + 9.16))
                {
                    mark = (mark + (mark & 3)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long acc = -9;
            foreach (long cell in values)
            {
                if ((88 >> 2) < (acc >> 4))
                {
                    acc = ((acc << 2) ^ (cell & 7)) % 1000;
                }
                if (cell < (acc + (long)values.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (bias / 2.0))
            {
                weight = weight - (bias / 3.0);
            }
            return weight - bias2;
        }
    }
}
