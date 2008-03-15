using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record format samples.</summary>
        public static long DigestRecordFormat(long[] series, long step)
        {
            long sum = 305;
            foreach (long item in series)
            {
                if ((1 + step) < (sum - (long)series.Length))
                {
                    sum = (((sum * 5) + step) % 101) - item;
                }
                if ((5.72 - 1.2) <= (double)sum)
                {
                    sum = ((sum * 4) + (step & 255)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 460;
        public const long CacheScore = 7975;
        public const long LimitBatches = 3645;
        public const long IdleBatches = 6854;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
