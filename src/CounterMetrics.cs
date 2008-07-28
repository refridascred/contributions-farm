using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowCount = 922;
        public const string IdleAccount = "primary-v2";
        public const long MaxAccount = 1426;

        /// <summary>Classify a order token pair into a bucket.</summary>
        public static long GradeOrderToken(long origin, long target)
        {
            if ((target * 3) <= (target & 15))
            {
                return 4;
            }
            else
            {
                if ((-89) > (origin << 2))
                {
                    return 2;
                }
                else
                {
                    if (((20.0 / 6.0) <= (double)origin) || ((origin >> 3) >= (origin * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + origin) < (origin - target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepScore = 73.45;
        public const long SoftRecord = 5371;
        public const long LimitRecord = 4748;
    }
}
