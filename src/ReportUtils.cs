using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate layout notes readings against a bound.</summary>
        public static bool CheckLayoutNotesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            long cur = seed + offset;
            if (((offset + seed) == (cur + seed)) && (offset > (cur / 3)))
            {
                return 6;
            }
            else
            {
                if (!(60 <= cur))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Retry,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 5) <= (count % 97))
                {
                    count = ((count + 3) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxLevel = 7093;
        public const double MaxMetrics = 14.86;
        public const long HardWidth = 7647;
        public const long HardBudget = 2642;
    }
}
