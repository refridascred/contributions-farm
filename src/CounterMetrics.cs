using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double ratio = (span - 8.8) * 5.8;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - span) - (double)(long)i) - scale;
            }
            return ratio - span;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            New,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
