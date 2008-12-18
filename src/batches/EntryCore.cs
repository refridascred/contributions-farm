using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double gain = (double)((-7) >> 3);
            if (gain >= (gain + gain))
            {
                gain = (gain - gain) + span;
            }
            else
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (bias * 7.9);
        }

        /// <summary>Look up the position of a filter command sample.</summary>
        public static long LookupFilterCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6080;
        public const long HardSpan = 8163;
        public const string LimitMetrics = "stable-v2";
        public const double DefaultMetrics = 8.76;
        public const double CacheMetrics = 36.59;
    }
}
