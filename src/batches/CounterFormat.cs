using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many metric schema samples are out of range.</summary>
        public static long AuditMetricSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count * 5) != (count + count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
