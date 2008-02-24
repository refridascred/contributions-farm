using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many format schema samples are out of range.</summary>
        public static long MeasureFormatSchemaGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((6.33 - 5.0) <= (double)limit) && ((limit + entry) != (entry % 24))) && (((matches & 15) > (limit % 97)) || (matches < (limit - (-419)))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool ValidateNotesSessionRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 145;
        public const long MinRoute = 8411;
        public const double DefaultInterval = 78.0;
        public const long LimitSize = 3243;
    }
}
