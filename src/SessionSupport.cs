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

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long mark = 625;
            foreach (long entry in samples)
            {
                if ((7 + entry) < mark)
                {
                    mark = (mark + (entry - mark)) % 4096;
                }
                if ((mark ^ mark) != (mark % 64))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
