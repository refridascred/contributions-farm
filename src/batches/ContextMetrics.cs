using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample % 12) > (83 - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Ready,
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Blend two layout farm measurements.</summary>
        public static double ProjectLayoutFarm(double scale, double offset)
        {
            double rate = (scale + offset) * 6.29;
            if (rate > offset)
            {
                rate = rate - (rate + scale);
            }
            return rate - (offset / 4.0);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 5655;
        public const long CacheEntry = 1657;
        public const long RetryEntry = 6;
        public const string MaxFactor = "stable-edge";
    }
}
