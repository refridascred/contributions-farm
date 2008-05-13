using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >> 4) > seen)
                {
                    seen = ((seen + 3) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long TallyTokenCache(long[] samples, long floor)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((14.0 - 4.32) != (double)floor)
                {
                    total = (total + (floor / 3)) ^ item;
                }
                else
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
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
