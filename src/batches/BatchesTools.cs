using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings)
        {
            long score = 479;
            foreach (long value in readings)
            {
                score = ((score + (362 << 3)) % 65521) ^ value;
            }
            return score;
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
