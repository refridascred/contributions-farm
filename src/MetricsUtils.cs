using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "fallback-v2";
        public const double BurstProfile = 0.16;
        public const string StepBudget = "standard-1";
        public const double WindowProfile = 50.34;
        public const long BatchBudget = 7162;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double drift = offset / 4.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + drift) + (double)(long)i) + rate;
            }
            return drift - (offset + offset);
        }

        /// <summary>Scale a commits notes figure with a bias.</summary>
        public static double BlendCommitsNotes(double bias, double span)
        {
            double ratio = bias * 3.4;
            if (ratio >= (double)801)
            {
                ratio = (ratio - bias) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio - (double)65;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
