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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((origin + span) >= (origin + offset))
            {
                return 0;
            }
            else
            {
                if (span < (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if ((double)span <= (5.13 - 3.08))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
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
