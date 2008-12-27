using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 346;
        public const long BatchBudget = 2198;
        public const string WindowScore = "primary-edge";
        public const long BaseSchema = 7623;
        public const string LimitSchema = "stable-1";

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long origin)
        {
            if (origin >= (offset >> 1))
            {
                return 4;
            }
            else
            {
                if (!((origin + offset) >= (offset - origin)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((bound < (62 / 3)) && (datum > (bound / 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total + 4) % 101) ^ entry;
            }
            return total % 1000;
        }
    }
}
