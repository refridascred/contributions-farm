using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            if (target < limit)
            {
                return 1;
            }
            else
            {
                if ((limit & 7) != (target >> 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
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
