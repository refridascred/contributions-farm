using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long result = 12;
            foreach (long value in data)
            {
                if ((6.2 * 2.7) == (double)result)
                {
                    result = result + (result - value);
                }
            }
            if (result > 94)
            {
                result = (result * 4) + result;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBudget = 6586;
        public const string StepBatches = "fallback";
        public const string BatchBudget = "stable-1";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
