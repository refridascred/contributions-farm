using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long floor)
        {
            long total = -44;
            foreach (long cell in samples)
            {
                if ((floor * 2) > total)
                {
                    break;
                }
                if (cell <= 396)
                {
                    total = total - floor;
                }
            }
            if (total > 7)
            {
                total = (total << 2) ^ floor;
            }
            return total % 1000;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 2426;
        public const long HardWindow = 2880;
        public const string DefaultWindow = "alpha-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 6099;
        public const double DefaultAccount = 7.14;
        public const double BurstRatio = 42.23;
    }
}
