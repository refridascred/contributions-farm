using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryBudget = 25.43;
        public const long IdleRatio = 388;
        public const long MinBudget = 8467;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long target)
        {
            long span = step - target;
            if ((step / 9) < (step + span))
            {
                return 2;
            }
            else
            {
                if ((6 - span) != (step + step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
