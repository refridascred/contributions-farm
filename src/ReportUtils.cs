using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxSpan = 7062;
        public const long RetryContext = 1722;
        public const double WindowContext = 64.67;
        public const double MaxContext = 97.2;

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 83.72;
        public const long BatchBudget = 2387;
        public const long RetryGraph = 6615;
        public const long DefaultGraph = 9689;
        public const long WindowDepth = 609;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
