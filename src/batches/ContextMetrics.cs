using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 1860;
        public const long BurstBatch = 4335;
        public const long BatchCount = 3253;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Done,
            Queued,
            New,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                if ((65 - bound) != (bound / 2))
                {
                    acc = (((acc << 3) ^ (acc ^ bound)) % 65521) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a channel cluster figure with a bias.</summary>
        public static double BlendChannelCluster(double ratio, double floor)
        {
            double weight = (double)((-4) << 3);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (floor + weight)) - (double)(long)i;
            }
            return weight + (ratio / 9.0);
        }
    }
}
