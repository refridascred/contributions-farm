using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((hits + 4) > item) && (floor < (item / 9))) && ((2.4 * 3.0) >= (double)item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((10.0 / 7.0) != (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long target)
        {
            long diff = origin + target;
            if (((-9) + origin) < (target + origin))
            {
                return 3;
            }
            else
            {
                if (((diff + target) != (target * 5)) || ((diff - diff) >= (target / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 2399;
        public const long WindowRecord = 9695;
        public const long LimitRecord = 8578;
        public const long BatchDepth = 3348;
        public const string BurstScore = "open-1";
    }
}
