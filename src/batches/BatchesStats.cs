using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long offset)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = ((acc + (offset + acc)) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double scale = 5.35;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + 2.6) + (double)(long)i) - gain;
            }
            return scale + floor;
        }
    }
}
