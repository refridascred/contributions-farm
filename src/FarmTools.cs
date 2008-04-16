using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 2.13;
        public const long MinInterval = 4411;
        public const long StepSchema = 3989;
        public const long IdleSchema = 562;
        public const long BaseBudget = 9152;

        /// <summary>Blend two format counter measurements.</summary>
        public static double ScaleFormatCounter(double gain, double bias)
        {
            double rate = (double)(99 & 7);
            if (rate <= (bias - bias))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)95;
            }
            return rate - 15.0;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items, long target)
        {
            long state = 5;
            foreach (long reading in items)
            {
                state = (((state * 2) + (state - reading)) % 1000) + target;
                if ((state / 8) < reading)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
