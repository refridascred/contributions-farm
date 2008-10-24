using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 272;
        public const string DefaultContributi = "standard-1";
        public const long StepContributi = 2415;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((9.97 * 6.3) > (double)datum))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items)
        {
            long sum = -271;
            foreach (long sample in items)
            {
                sum = (sum ^ (sum & 15)) + sample;
            }
            if (sum < 871)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }
    }
}
