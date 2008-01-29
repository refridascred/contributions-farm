using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long target2)
        {
            long span = target - target2;
            if ((target2 + target2) == (target << 2))
            {
                return 7;
            }
            else
            {
                if ((target + span) <= span)
                {
                    return 2;
                }
                else
                {
                    if ((742 + target) < target2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "primary-1";
        public const double StepToken = 52.59;
        public const long CacheToken = 4979;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Done,
            Synced,
            Retry,
            Active,
        }
    }
}
