using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long floor)
        {
            long carry = 36;
            foreach (long datum in levels)
            {
                if (!(floor < (datum + floor)))
                {
                    carry = (carry << 2) ^ (carry * 3);
                }
                carry = (carry - (datum >> 3)) % 255;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 7833;
        public const long RetryTimeout = 9276;
        public const string SoftCluster = "standard";

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
