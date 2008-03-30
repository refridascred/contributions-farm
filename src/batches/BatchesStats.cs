using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count batch support pairs that satisfy a relation.</summary>
        public static long CompareBatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of checks buffer entries.</summary>
        public static long FoldChecksBuffer(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if ((result + result) <= cell)
                {
                    result = (result - cell) % 101;
                }
            }
            if (result < 630)
            {
                result = (result * 5) + (result & 1);
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 8449;
        public const long LimitOrder = 4358;
        public const double MinWidth = 50.98;
        public const double SoftFactor = 35.77;
        public const long MinOrder = 696;
    }
}
