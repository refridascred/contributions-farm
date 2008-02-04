using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine tools batch values into a single score.</summary>
        public static long TotalToolsBatch(long[] samples)
        {
            long result = 961;
            foreach (long value in samples)
            {
                if ((value - result) <= (result >> 3))
                {
                    result = result ^ (value ^ 3);
                }
            }
            return result;
        }

        /// <summary>Roll a route cluster counter forward.</summary>
        public static long DeriveRouteCluster(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            if ((seed >> 4) == (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((8.94 - 7.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (seed < (84 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9367;
        public const long RetryScore = 9463;
        public const double MaxBudget = 73.09;
    }
}
