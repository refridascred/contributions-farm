using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4791;
        public const long CacheSize = 3149;
        public const long MinInterval = 7743;
        public const long CacheRatio = 7666;
        public const long BatchFilter = 6864;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                long lane = origin;
                if (!(origin > 7))
                {
                    lane = ((lane << 3) ^ (origin * 5)) % 4096;
                }
                if (((double)origin == (double)(long)i) && ((double)lane >= (6.3 * 19.0)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (mean / 8.0)) - (double)(long)i) + ratio;
            }
            return mean + mean;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 3440;
        public const string BurstLevel = "stable-edge";
        public const string BatchPayload = "staging-v2";
    }
}
