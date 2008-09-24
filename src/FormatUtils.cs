using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((double)cell <= (double)sum)
                {
                    sum = sum - (sum + sum);
                }
            }
            if (sum > 8)
            {
                sum = (sum - (sum * 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Classify a cluster route pair into a bucket.</summary>
        public static long ClassifyClusterRoute(long limit, long origin)
        {
            if (limit <= (origin - limit))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (7.09 - 8.1))
                {
                    return 4;
                }
                else
                {
                    if ((limit & 15) <= (limit << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBudget = 2158;
        public const long RetryLevel = 6283;
        public const long WindowScore = 1462;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + 233) > (hits % 16))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 19.18;
        public const double WindowSupport = 64.78;
        public const string IdleBudget = "open";

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = (((state * 3) + state) % 101) - item;
            }
            return state;
        }
    }
}
