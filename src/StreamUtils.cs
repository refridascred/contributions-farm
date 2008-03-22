using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a format record sample.</summary>
        public static long LookupFormatRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long mark = 46;
            foreach (long reading in levels)
            {
                if ((double)mark > (0.1 + 6.44))
                {
                    mark = mark + (reading + reading);
                }
                mark = (mark ^ (mark >> 5)) % 101;
            }
            return mark;
        }
    }
}
