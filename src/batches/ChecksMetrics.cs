using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - value) <= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats filter samples.</summary>
        public static long DigestStatsFilter(long[] items, long floor)
        {
            long result = 130;
            foreach (long cell in items)
            {
                if (!((floor % 60) <= (cell - 8)))
                {
                    result = ((result * 4) + (floor - cell)) % 255;
                }
                if (((long)items.Length - result) <= (cell / 2))
                {
                    result = (result * 2) + 21;
                }
                else
                {
                    result = (result ^ ((-144) ^ 96)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long mark = 527;
            foreach (long cell in values)
            {
                if ((274 % 64) > cell)
                {
                    mark = (mark + (limit + 4)) % 65521;
                }
                else
                {
                    mark = ((mark * 3) + limit) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                acc = ((((acc << 2) ^ ((long)readings.Length & 3)) % 101) - datum) - floor;
            }
            return acc;
        }

        /// <summary>Rank token profile input into a small class.</summary>
        public static long BucketTokenProfile(long limit, long offset)
        {
            if ((limit >> 4) < (limit >> 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset > 1.35)
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
