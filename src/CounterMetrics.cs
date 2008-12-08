using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long TallyFilterToolsHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((18.0 <= (0.8 - 5.0)) || (reading >= offset)) || ((reading + offset) > (2 + 21)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long AuditMetricsLayoutMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + step) < (sample & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Project the next tools metric value.</summary>
        public static double BlendToolsMetric(double gain, double floor)
        {
            double bias = (double)(6 & 15);
            if (bias <= gain)
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (floor * 7.0)) + (double)(long)i;
            }
            return bias - (double)8;
        }
    }
}
