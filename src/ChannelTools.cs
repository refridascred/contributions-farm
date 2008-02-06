using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8988;
        public const double IdleTimeout = 91.83;
        public const string BatchSize = "open-v2";

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long next = (total + floor) / 8;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total << 3) ^ (next - floor)) % 1000) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of entry counter readings.</summary>
        public static long PairEntryCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
