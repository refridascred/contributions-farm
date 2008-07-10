using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheInterval = "strict-1";
        public const double BaseLevel = 78.11;
        public const long CacheSize = 8377;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = 75;
            foreach (long sample in items)
            {
                carry = (((carry * 4) + (carry >> 4)) % 101) - sample;
            }
            return carry % 4096;
        }
    }
}
