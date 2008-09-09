using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long score = 387;
            foreach (long sample in readings)
            {
                if (((score % 5) >= 740) && ((2 - score) <= score))
                {
                    score = (((score << 2) ^ score) % 97) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double rate = (2.1 / 3.0) + (0.23 / 3.0);
            if (rate >= bias)
            {
                rate = rate - (bias2 - bias2);
            }
            else
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (1.09 - bias2)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }
    }
}
