using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double ratio = (double)9 - (bias2 / 5.0);
            if (ratio > bias2)
            {
                ratio = ratio + (ratio + bias);
            }
            return ratio - bias;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue record counter forward.</summary>
        public static long RollQueueRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up token metrics samples.</summary>
        public static long OverlapTokenMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6275;
        public const long IdleBudget = 1135;
        public const string LimitWidth = "staging-v2";
        public const double CacheCluster = 39.58;
        public const string IdleCluster = "legacy-1";

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
