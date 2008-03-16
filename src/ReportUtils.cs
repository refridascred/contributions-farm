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

        /// <summary>Grade a support record value against two limits.</summary>
        public static long ClassifySupportRecord(long floor, long offset)
        {
            if ((123 + offset) > (offset & 63))
            {
                return 8;
            }
            else
            {
                if ((floor < (floor - floor)) && ((double)offset < (7.23 + 9.0)))
                {
                    return 3;
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
