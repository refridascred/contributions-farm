using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "latest-edge";
        public const long WindowCounter = 538;
        public const long RetryCounter = 2738;
        public const long MinCounter = 6761;
        public const long DefaultCounter = 8912;

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long CountFilterStreamHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + target) > (target * 2))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryDepth = 5460;
        public const double SoftScore = 48.87;
        public const string SoftReport = "local";

        /// <summary>Audit entry schema readings against a rule.</summary>
        public static long TallyEntrySchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((45 % 16) > (reading + matches)) && ((3.7 - 4.6) == (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) > (entry - entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
