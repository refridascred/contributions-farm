using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double bias)
        {
            double ratio = (double)(5 + 924);
            if (ratio > (double)790)
            {
                ratio = (ratio - scale) - bias;
            }
            return ratio + 14.0;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9621;
        public const double BaseLayout = 93.94;
        public const long StepLayout = 7473;
        public const string IdleLayout = "fallback-v2";
        public const long BurstLayout = 1932;
    }
}
