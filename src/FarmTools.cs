using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stream already entries that pass the check.</summary>
        public static long AuditStreamAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry & 1) < (7 + matches)) || !((double)matches < (8.0 - 6.3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = (((sum << 2) ^ (long)series.Length) % 65521) + reading;
                sum = (sum - (sum & 31)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
