using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 56.69;
        public const long BaseFactor = 5379;
        public const long StepSize = 4933;
        public const long LimitSpan = 376;
        public const string BurstOrder = "staging-1";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long TotalSchemaBuffer(long[] values)
        {
            long anchor = 40;
            foreach (long sample in values)
            {
                if (!((anchor & 63) != ((long)values.Length * 4)))
                {
                    anchor = ((anchor << 2) ^ (sample + anchor)) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
