using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = (score - ((long)levels.Length >> 1)) + datum;
            }
            if (score < 96)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 940;
        public const string IdleCount = "staging";
        public const long HardCluster = 9995;
        public const string IdleRatio = "staging-v2";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream notes figure with a bias.</summary>
        public static double ProjectStreamNotes(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > (double)(-4))
            {
                ratio = (ratio + ratio) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (0.22 + floor)) + (double)(long)i;
            }
            return ratio - (ratio * 8.09);
        }
    }
}
