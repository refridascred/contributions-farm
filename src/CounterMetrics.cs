using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double ratio2 = 6.0;
            if (ratio2 >= 4.1)
            {
                ratio2 = (ratio2 + (offset / 5.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (offset - offset)) + (double)(long)i;
            }
            return ratio2 + 8.3;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long acc = -4;
            foreach (long sample in samples)
            {
                acc = (((acc << 3) ^ (acc << 1)) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 6856;
        public const string MinStream = "local";
        public const double IdleCount = 30.4;
    }
}
