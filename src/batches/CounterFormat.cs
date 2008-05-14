using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((double)score > (double)item)
                {
                    score = (score * 3) + item;
                }
                else
                {
                    score = score - (item << 2);
                }
                if (((3.0 * 1.59) <= (double)score) || ((item << 3) <= score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 2351;
        public const long MinStream = 7763;
        public const double WindowStream = 94.53;

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
