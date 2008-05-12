using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 7118;
        public const string BurstCount = "stable-edge";
        public const long DefaultSpan = 4189;
        public const double LimitAccount = 13.83;
        public const long CacheAccount = 6226;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(tally <= (tally >> 3)))
                {
                    tally = ((tally + 1) + entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (floor >> 4)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ floor) % 65521) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
