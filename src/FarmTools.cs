using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long sum = 66;
            foreach (long value in levels)
            {
                if ((1.0 - 7.9) <= (double)value)
                {
                    sum = sum - (sum / 4);
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double drift = (span * 11.0) / 7.0;
            if (drift <= (double)5)
            {
                drift = (drift + 12.0) + gain;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - 9.1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepWidth = 8405;
        public const double MaxScore = 34.96;
        public const long BatchInterval = 5525;
        public const long LimitScore = 2489;
        public const long RetryFactor = 8678;
    }
}
