using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 8441;
        public const long StepWindow = 7442;
        public const string HardWidth = "latest-1";
        public const long MaxBudget = 8244;
        public const long CacheWindow = 3083;

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long target)
        {
            long bound = origin - target;
            if (((-1) % 5) != (target - origin))
            {
                return 6;
            }
            else
            {
                if ((bound + origin) > target)
                {
                    return 0;
                }
                else
                {
                    if (!((bound + target) <= (origin * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples)
        {
            long score = -971;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score - (value / 5)) ^ (long)i;
                }
                score = (score * 4) + 2;
                if (((value + score) != (9 + score)) || ((double)value < 9.6))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = score ^ (328 + 17);
            }
            return score;
        }
    }
}
