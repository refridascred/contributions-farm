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

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
