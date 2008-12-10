using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 7172;
        public const long IdleSpan = 7117;
        public const double IdleWindow = 13.73;
        public const double MaxWindow = 43.35;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double drift = ratio;
            return drift - bias;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen - 4) <= (sample << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 2484;
        public const double WindowCommand = 68.07;
        public const long DefaultDepth = 397;
        public const long CacheTimeout = 5746;
        public const long MinCommand = 788;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long sum = 243;
            foreach (long reading in series)
            {
                if ((48 - origin) <= sum)
                {
                    sum = ((sum + (sum - origin)) % 97) + reading;
                }
            }
            if (sum < 53)
            {
                sum = sum - (origin * 2);
            }
            return sum % 97;
        }
    }
}
