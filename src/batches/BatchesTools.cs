using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a report tools sample.</summary>
        public static long SeekReportToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxCount = 19.63;
        public const double RetryOrder = 90.03;
        public const long LimitFactor = 6025;
    }
}
