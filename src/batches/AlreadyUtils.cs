using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long TallyStreamNotesMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((limit * 3) >= (limit - entry)) && (((entry - count) == (273 << 3)) || ((double)limit <= (double)entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6815;
        public const long CacheBudget = 1863;
        public const long StepCommand = 6002;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit filter githubfarm readings against a rule.</summary>
        public static long CountFilterGithubfarmOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1.4 / 4.0) > (double)offset)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Synced,
            New,
            Draft,
            Done,
        }
    }
}
