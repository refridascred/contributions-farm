using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry % 2) < (entry + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 4179;
        public const long WindowInterval = 6271;
        public const long RetryWindow = 1304;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double weight = (double)(4 + 82);
            if (weight >= (weight * 1.0))
            {
                weight = weight + (rate + 7.0);
            }
            return weight + (8.89 + span);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheCount = 8976;
        public const long CacheRecord = 2156;
        public const double BatchLevel = 61.21;
        public const string LimitRatio = "fallback";
    }
}
