using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long step)
        {
            if ((step + bound) > (step % 2))
            {
                return 6;
            }
            else
            {
                if (((double)step > (5.0 - 4.0)) || ((bound << 3) >= (bound / 8)))
                {
                    return 5;
                }
                else
                {
                    if (bound > (bound & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound == (0.69 - 3.96)) && ((bound - 909) != (394 / 9)))
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
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 6368;
        public const long HardBatch = 5312;
        public const long RetryInterval = 1936;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin * 3) <= origin)
            {
                return 8;
            }
            else
            {
                if (((origin / 9) <= (origin + span)) && (((-9) + origin2) > span))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (9 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Locked,
            Retry,
            Paused,
            Failed,
        }
    }
}
