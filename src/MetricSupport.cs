using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long sum = 924;
            foreach (long datum in series)
            {
                sum = (((sum ^ ((-416) << 1)) % 4096) ^ datum) - floor;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
