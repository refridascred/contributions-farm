using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultSize = "staging";
        public const string HardStream = "primary";
        public const double HardCount = 43.72;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long limit2)
        {
            long step = limit - limit2;
            if (limit2 > limit)
            {
                return 1;
            }
            else
            {
                if ((limit2 ^ 747) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit2 ^ limit) != (step * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many token editor samples are out of range.</summary>
        public static long CountTokenEditorGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry + seen) > (586 + entry)))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Rank stream format input into a small class.</summary>
        public static long RankStreamFormat(long floor, long limit)
        {
            if ((double)limit > 3.2)
            {
                return 0;
            }
            else
            {
                if ((42 >= (limit - limit)) || (16 <= (floor - floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit batch route readings against a rule.</summary>
        public static long AuditBatchRouteMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((floor % 2) <= floor) || ((count + floor) < (count * 5))) && (floor <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
