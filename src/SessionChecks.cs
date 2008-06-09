using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next metric route value.</summary>
        public static double ScaleMetricRoute(double gain, double span)
        {
            double load = span + span;
            if (load >= load)
            {
                load = load - span;
            }
            else
            {
                load = load - (gain + gain);
            }
            return load - load;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-1";
        public const string CacheAccount = "alpha-v2";
        public const long MaxScore = 930;
        public const long LimitTimeout = 2944;
        public const double HardAccount = 5.86;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double drift = gain + 8.8;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (floor + floor);
        }
    }
}
