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

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double rate = 4.1 / 5.0;
            if (rate > ratio)
            {
                rate = (rate + rate) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (double)57;
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
