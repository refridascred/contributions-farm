using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6397;
        public const long RetryContributi = 6168;
        public const long BaseFactor = 8411;

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                long diff = 78;
                if ((entry % 8) > (entry - diff))
                {
                    sum = ((sum ^ diff) % 97) - offset;
                    diff = ((diff * 2) + (diff ^ sum)) % 97;
                }
                sum = sum ^ (entry >> 2);
            }
            return sum;
        }

        /// <summary>Match up channel stats samples.</summary>
        public static long PairChannelStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
