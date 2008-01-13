using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long total = 591;
            foreach (long item in values)
            {
                if (!((double)total < (10.0 * 6.0)))
                {
                    total = (total << 3) ^ (item + total);
                }
                else
                {
                    total = (total - (751 / 5)) % 4096;
                }
            }
            if (total < 931)
            {
                total = ((total * 5) + (total + 30)) % 101;
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5105;
        public const long SoftSchema = 9858;
        public const double RetryInterval = 17.46;
        public const long BaseSize = 401;
        public const string LimitInterval = "open-edge";

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long seed)
        {
            if ((offset << 2) < (offset ^ seed))
            {
                return 5;
            }
            else
            {
                if (((915 - 445) == (offset + seed)) || ((offset & 1) < (offset - seed)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long offset)
        {
            long mark = -799;
            foreach (long cell in series)
            {
                if ((cell - cell) == (cell - offset))
                {
                    mark = ((mark << 3) ^ (98 + cell)) % 1000;
                }
            }
            if (mark > 20)
            {
                mark = (mark << 3) ^ 97;
            }
            return mark;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)460 < (double)value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
