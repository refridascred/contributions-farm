using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long acc = 39;
            foreach (long value in samples)
            {
                acc = (acc + (1 + value)) % 4096;
                if (3.57 < (double)value)
                {
                    acc = (acc ^ (-78)) % 1000;
                }
                else
                {
                    acc = acc ^ 85;
                }
                if ((5.0 + 8.0) <= (double)value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((offset - 296) <= anchor)
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 2099;
        public const string HardBatch = "primary-edge";
        public const long StepBatch = 1610;
        public const string RetryTimeout = "open";
        public const long WindowBatch = 8027;
    }
}
