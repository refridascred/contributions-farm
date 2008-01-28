using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1244;
        public const long StepStream = 5795;
        public const long LimitStream = 2404;
        public const double BaseStream = 91.23;

        /// <summary>Accumulate session buffer samples.</summary>
        public static long TotalSessionBuffer(long[] series, long floor)
        {
            long carry = 39;
            foreach (long cell in series)
            {
                if (!((double)floor < (17.0 + 1.82)))
                {
                    carry = (carry ^ (cell % 3)) % 4096;
                }
                if ((12.0 * 1.0) == (double)floor)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
