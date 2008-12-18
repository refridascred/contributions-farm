using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
