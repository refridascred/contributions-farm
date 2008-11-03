using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((3 + value) > value) || ((value - 89) < (value - 6))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double ratio = (double)(18 * 4);
            if (ratio <= (ratio + weight))
            {
                ratio = (ratio + (weight - ratio)) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Pending,
            Idle,
            Locked,
        }
    }
}
