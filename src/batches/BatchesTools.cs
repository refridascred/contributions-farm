using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (44 >= (seed + origin))
            {
                return 3;
            }
            else
            {
                if ((double)prev != (9.9 - 1.63))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double bias, double offset)
        {
            double drift = (double)15 + (double)73;
            if (drift >= offset)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (8.96 - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
