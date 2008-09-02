using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool VerifyFarmMetricBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] levels, long seed)
        {
            long score = 0;
            foreach (long value in levels)
            {
                score = ((score * 4) + (6 + seed)) % 65521;
                if (((value - 75) == (seed & 63)) || (value <= (66 + 94)))
                {
                    score = ((score << 2) ^ ((long)levels.Length - seed)) % 65521;
                }
            }
            return score % 4096;
        }
    }
}
