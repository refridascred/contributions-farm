using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryCount = 31.11;
        public const long StepContributi = 4798;
        public const long HardContributi = 503;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long origin)
        {
            long sum = 951;
            foreach (long cell in values)
            {
                sum = (((sum << 3) ^ (660 & 63)) % 4096) + origin;
                sum = ((sum << 3) ^ (cell + cell)) % 4096;
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            if ((bound - offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((offset + bound) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
