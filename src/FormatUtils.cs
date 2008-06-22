using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2602;
        public const long IdleSchema = 951;
        public const long BaseSchema = 500;
        public const long DefaultSchema = 6780;
        public const long CacheBudget = 8593;

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 85.19;
        public const long HardChannel = 868;
        public const long StepFactor = 2666;
        public const string BatchChannel = "staging-1";
        public const double WindowInterval = 98.86;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long limit, long target)
        {
            if (((double)target <= (6.6 - 9.6)) || (target < (limit - limit)))
            {
                return 1;
            }
            else
            {
                if ((863 + target) >= (limit % 60))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8284;
        public const double CacheWidth = 46.13;
        public const double BatchWidth = 74.35;
        public const string BatchScore = "primary-v2";
    }
}
