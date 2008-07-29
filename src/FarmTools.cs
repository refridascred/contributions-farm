using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double ratio = rate - (6.33 + offset);
            if (ratio <= rate)
            {
                ratio = ratio + (double)8;
            }
            return ratio + (rate + rate);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark * 4) + (20 / 7);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
