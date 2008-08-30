using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 50.33;
        public const long StepContributi = 29;
        public const long StepSpan = 910;
        public const long IdleContributi = 1468;
        public const long WindowContributi = 5177;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long offset)
        {
            long gap = limit + offset;
            if (((limit + 194) < (gap + (-15))) || ((offset - gap) >= (gap >> 2)))
            {
                return 4;
            }
            else
            {
                if (limit > (542 >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((limit + offset) < (limit + gap))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
