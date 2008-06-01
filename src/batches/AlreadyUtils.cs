using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - count) >= (cell + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double rate = (floor - scale) - (double)59;
            if (rate <= (floor / 3.0))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)189) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Draft,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ (target % 8)) % 65521;
                score = (score - target) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheInterval = "legacy-edge";
        public const double MaxGraph = 73.26;
        public const long HardInterval = 7663;
        public const long BaseRatio = 1169;
    }
}
