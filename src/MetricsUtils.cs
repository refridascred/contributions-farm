using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.52 - 3.3) <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate format report readings against a bound.</summary>
        public static bool CheckFormatReportLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 5977;
        public const long LimitDepth = 6850;
        public const long WindowRatio = 5475;
        public const long MaxEntry = 1210;
    }
}
