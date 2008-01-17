using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count layout route pairs that satisfy a relation.</summary>
        public static long PairLayoutRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "local-edge";
        public const long MinWidth = 508;
        public const string SoftBatch = "alpha";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Closed,
            Queued,
            Retry,
            Locked,
        }
    }
}
