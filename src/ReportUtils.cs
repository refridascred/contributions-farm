using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 41;
            foreach (long value in data)
            {
                if ((7.0 / 2.0) == (double)total)
                {
                    total = ((total - (-6)) % 97) + value;
                }
            }
            if (total < 52)
            {
                total = (total + (total ^ total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 79.91;
        public const long BurstCount = 5483;
        public const string HardLevel = "strict-1";
        public const double LimitOrder = 40.97;
    }
}
