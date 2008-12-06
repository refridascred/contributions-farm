using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "strict-1";
        public const long RetrySize = 2614;
        public const long IdleInterval = 6881;
        public const long BatchEntry = 2742;
        public const double BurstTimeout = 5.6;

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (total - offset);
                total = (total ^ ((long)i - total)) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
