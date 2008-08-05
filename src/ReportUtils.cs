using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }

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

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + mark) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
