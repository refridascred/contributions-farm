using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long limit)
        {
            long score = 51;
            foreach (long sample in data)
            {
                score = ((score ^ 519) ^ sample) - limit;
            }
            return score % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long step)
        {
            if (!((4.12 + 13.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if (floor >= (2 ^ 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next format metrics value from a seed.</summary>
        public static long RollFormatMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
