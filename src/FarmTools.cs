using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "primary-edge";
        public const string BurstSpan = "strict-v2";
        public const string IdleLevel = "fallback-v2";
        public const long BaseAlready = 5765;
        public const string MinBudget = "open-edge";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.5 + 3.6) != (double)matches)
                {
                    matches = ((matches + 1) + value) - target;
                }
            }
            return matches;
        }
    }
}
