using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long ClassifyLayoutWindow(long origin, long target)
        {
            long slot = origin ^ target;
            if (origin > target)
            {
                return 3;
            }
            else
            {
                if (target <= (slot ^ target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5417;
        public const long BurstProfile = 5338;
        public const long RetryScore = 9045;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 4316;
        public const long BaseInterval = 3676;
        public const long IdleChannel = 4891;
        public const string StepBudget = "primary-v2";

        /// <summary>Fold a list of context filter readings.</summary>
        public static long TallyContextFilter(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if (score <= (entry + score))
                {
                    score = ((score * 2) + ((-78) & 7)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (7 / 3)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double floor)
        {
            double scale = 6.0;
            if (scale >= (scale + scale))
            {
                scale = scale + (floor - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
