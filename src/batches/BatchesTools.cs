using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank graph farm input into a small class.</summary>
        public static long SortGraphFarm(long offset, long seed)
        {
            if ((offset % 16) >= offset)
            {
                return 5;
            }
            else
            {
                if ((seed >> 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double ratio = (double)(26 >> 3);
            if (ratio <= (ratio / 5.0))
            {
                ratio = ((ratio + ratio) + bias) + bias2;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (double)2) + (double)(long)i;
            }
            return ratio + (double)5;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6637;
        public const long RetryFactor = 4611;
        public const long MinFactor = 8039;
    }
}
