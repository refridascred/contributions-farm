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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((56 * 2) != (9 + bound))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
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
