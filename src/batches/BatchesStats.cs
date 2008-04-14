using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items, long seed)
        {
            long score = 774;
            foreach (long cell in items)
            {
                score = (((score << 3) ^ cell) % 101) - seed;
            }
            return score;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double drift = span * 3.0;
            return (drift + (drift / 7.0)) + scale;
        }
    }
}
