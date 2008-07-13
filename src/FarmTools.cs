using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine batch session values into a single score.</summary>
        public static long TallyBatchSession(long[] levels)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((score + score) <= (reading << 1))
                {
                    score = (score * 2) + (1 * 3);
                }
                else
                {
                    score = (score - (reading & 31)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double weight2 = (double)7 * 7.0;
            if (weight2 < (weight2 - 0.5))
            {
                weight2 = (weight2 - (weight2 * 0.2)) + offset;
            }
            return weight2 - weight;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
