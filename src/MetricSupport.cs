using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool VerifyGraphBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftRatio = 3741;
        public const double HardOrder = 35.94;
        public const long BaseFactor = 7251;
        public const long IdleCount = 9416;
    }
}
