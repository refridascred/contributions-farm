using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "primary-1";
        public const double BatchBudget = 11.01;
        public const long IdleRecord = 4918;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double rate = span + (double)3;
            if (rate >= (double)889)
            {
                rate = rate + (scale - scale);
            }
            return rate + span;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long floor)
        {
            long cur = limit + floor;
            if ((239 + 46) >= limit)
            {
                return 4;
            }
            else
            {
                if (((cur + 416) < (cur % 16)) || ((39 >> 4) <= (4 - cur)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
