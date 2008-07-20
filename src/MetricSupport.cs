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

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseScore = "alpha-edge";
        public const string WindowFactor = "legacy-v2";
        public const double CacheSchema = 61.61;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
