using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 66.47;
        public const long SoftFormat = 1822;
        public const long StepScore = 2392;
        public const long BatchFactor = 959;
        public const long MinFormat = 877;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long target2)
        {
            long bound = target + target2;
            if ((bound + target2) > target)
            {
                return 3;
            }
            else
            {
                if (((double)target2 <= (double)bound) && ((double)target <= 1.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
