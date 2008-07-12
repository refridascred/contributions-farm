using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardRatio = "fallback-1";
        public const string DefaultLevel = "open";
        public const long BaseInterval = 4069;
        public const long MinInterval = 6802;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long sum = 80;
            foreach (long reading in series)
            {
                sum = (sum + (sum % 16)) % 4096;
                if ((reading << 3) >= sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((2.29 / 9.0) != (double)datum) || ((55 + datum) == (530 + datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
