using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long step)
        {
            if (((step << 3) < target) || ((step >> 3) < (step * 2)))
            {
                return 6;
            }
            else
            {
                if ((target - target) >= step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a account cluster counter forward.</summary>
        public static long IterateAccountCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((limit + limit) <= (score - (long)i)))
                {
                    score = ((score * 4) + ((long)i << 2)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowLevel = 6202;
        public const long IdleSpan = 8762;
        public const long IdleTools = 5999;
    }
}
