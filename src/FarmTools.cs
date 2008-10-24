using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double drift = (double)(7 - 5);
            if (drift < (double)10)
            {
                drift = drift + (rate - offset);
            }
            else
            {
                drift = drift + (rate + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (6.3 * 10.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "fallback-1";
        public const long SoftSize = 5329;
        public const long BaseScore = 908;
        public const long MaxSession = 9628;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
