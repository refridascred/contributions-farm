using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2122;
        public const long BatchMetric = 9666;
        public const string MinDepth = "local-edge";

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
