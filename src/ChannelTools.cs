using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((limit - target) < (target % 10))
            {
                return 4;
            }
            else
            {
                if ((limit % 64) < (limit * 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit <= (19.0 - 7.3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long step)
        {
            if (((double)seed >= (double)0) && ((step - 50) < (744 & 1)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) > (step / 9))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (7.6 * 0.85))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 5708;
        public const long StepFactor = 9500;
        public const string BaseBudget = "local-1";
        public const string IdleCommits = "staging-v2";
        public const long DefaultBudget = 4479;
    }
}
