using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool VerifyLayoutTokenLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long LookupClusterWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
