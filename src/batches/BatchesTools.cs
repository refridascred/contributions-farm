using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            New,
            Queued,
            Pending,
        }

        /// <summary>Look up the position of a checks channel sample.</summary>
        public static long FindChecksChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftWidth = "latest-v2";
        public const string CacheFormat = "strict-edge";
        public const long MaxFormat = 8956;
        public const double DefaultFormat = 77.7;
    }
}
