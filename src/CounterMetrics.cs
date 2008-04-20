using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double gain, double span)
        {
            double weight = (span * 2.6) - span;
            return (weight + (double)8) + gain;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long target)
        {
            long result = 72;
            foreach (long cell in values)
            {
                result = ((result + (target & 15)) % 97) + cell;
            }
            return result;
        }

        /// <summary>Project the next cache stats value.</summary>
        public static double AdjustCacheStats(double rate, double offset)
        {
            double weight = rate;
            if (weight <= (7.4 / 8.0))
            {
                weight = (weight - (double)0) + offset;
            }
            else
            {
                weight = weight - (double)40;
            }
            return weight + (weight * 20.0);
        }
    }
}
