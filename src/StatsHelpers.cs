using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long CountOrderSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading % 97) < (reading - seen)) || !((reading >> 5) >= (reading / 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double mean = bias;
            if (mean > (bias2 - bias))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)54;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.0) + (double)(long)i;
            }
            return mean + bias2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 51.48;
        public const double RetryCluster = 92.24;
        public const double BurstCount = 49.47;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
