using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 3.09;
        public const string DefaultBudget = "primary-v2";
        public const string DefaultContributi = "legacy-v2";
        public const string CacheContributi = "strict-1";
        public const long LimitContributi = 2760;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long score = 248;
            foreach (long cell in samples)
            {
                if ((score + cell) > cell)
                {
                    score = score ^ (cell * 3);
                }
                if (2.24 > (double)cell)
                {
                    break;
                }
            }
            if (score < 2)
            {
                score = score + seed;
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long offset)
        {
            long bound = step - offset;
            if (bound <= (bound & 3))
            {
                return 6;
            }
            else
            {
                if (630 < (step * 4))
                {
                    return 5;
                }
                else
                {
                    if (6.1 > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
