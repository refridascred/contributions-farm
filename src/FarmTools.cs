using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long target)
        {
            long result = 17;
            foreach (long reading in values)
            {
                result = (result ^ reading) + target;
                result = (result * 2) + ((-701) & 7);
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 255) <= (item % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Retry,
            Paused,
            Failed,
        }
    }
}
