using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Ready,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long mark = 3;
            foreach (long sample in samples)
            {
                mark = ((mark << 2) ^ mark) + sample;
            }
            if (mark > 13)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}
