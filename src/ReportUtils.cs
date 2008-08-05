using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheScore = 3824;
        public const string WindowMetrics = "strict-v2";
        public const long StepRatio = 6210;
        public const long StepMetrics = 3965;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((double)limit2 != (double)721)
            {
                return 4;
            }
            else
            {
                if (((2 & 63) <= (limit + limit)) && ((limit % 2) != (limit2 << 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit2 <= (9.7 * 4.61)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score + ((long)i2 - score)) % 101;
                }
                score = ((score * 3) + (score + (long)i)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((limit % 3) < (cell & 31)) || ((limit & 7) < (hits >> 1))) && (((double)cell != (double)limit) && (1.9 > (double)cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long origin, long offset)
        {
            if (((-73) < (offset << 3)) || ((origin / 6) > (offset - origin)))
            {
                return 7;
            }
            else
            {
                if (((double)offset >= 9.0) || ((offset - origin) > (origin * 4)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
