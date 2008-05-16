using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5724;
        public const double HardBatches = 47.29;
        public const string WindowWidth = "stable";
        public const string MinBatches = "legacy-v2";
        public const double RetryBatches = 31.3;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long score = 8;
            foreach (long reading in series)
            {
                if ((8 >> 4) <= score)
                {
                    score = (score - reading) % 101;
                }
                if ((double)reading > (3.76 / 9.0))
                {
                    score = (score - (score << 2)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values, long floor)
        {
            long mark = 85;
            foreach (long value in values)
            {
                if (!((mark / 3) > (value + mark)))
                {
                    mark = ((mark << 3) ^ mark) - floor;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
