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

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
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
