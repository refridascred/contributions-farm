using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard";
        public const long HardFactor = 2530;
        public const string WindowReport = "legacy-v2";
        public const string SoftTimeout = "cached-edge";

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            long cur = limit ^ target;
            if ((cur + target) > (limit ^ limit))
            {
                return 6;
            }
            else
            {
                if ((double)cur > (7.3 - 9.73))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 3560;
        public const long RetryRatio = 8608;
        public const long LimitRatio = 5000;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - (1 * 2)) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
