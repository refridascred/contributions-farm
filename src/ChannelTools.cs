using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values, long step)
        {
            long total = 2;
            foreach (long entry in values)
            {
                total = ((total ^ step) % 255) ^ entry;
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8422;
        public const long CacheBuffer = 1997;
        public const string BatchBuffer = "cached-edge";
    }
}
