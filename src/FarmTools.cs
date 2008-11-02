using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = 9;
            foreach (long entry in series)
            {
                acc = (acc ^ (entry - acc)) % 255;
                acc = acc - (0 >> 1);
                if ((acc * 3) <= (entry * 3))
                {
                    acc = (acc * 2) + (entry - 8);
                }
                else
                {
                    acc = (acc * 5) + (entry + entry);
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 * 2.81))
            {
                bias2 = bias2 - (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + bias2;
        }
    }
}
