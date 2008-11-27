using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a entry batch value against two limits.</summary>
        public static long ClassifyEntryBatch(long step, long target)
        {
            if ((2.2 - 2.36) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((double)target > (8.8 * 2.59))
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (9.0 - 9.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target < (5.43 - 7.86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 95.43;
        public const long StepBudget = 3904;
        public const string CacheNotes = "standard";
        public const long StepNotes = 3490;
        public const long MaxNotes = 5912;
    }
}
