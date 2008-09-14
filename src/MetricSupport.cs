using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] data)
        {
            long mark = 0;
            foreach (long value in data)
            {
                mark = (((mark << 2) ^ (mark ^ mark)) % 101) + value;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LookupToolsTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
