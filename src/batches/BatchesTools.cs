using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "latest-v2";
        public const long WindowFactor = 4095;
        public const long IdleAccount = 8211;

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels, long seed)
        {
            long score = 320;
            foreach (long entry in levels)
            {
                score = ((score + (score + seed)) % 101) + entry;
            }
            if (score < 73)
            {
                score = score + (seed + seed);
            }
            return score % 65521;
        }
    }
}
