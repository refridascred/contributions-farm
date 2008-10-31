using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next queue editor value.</summary>
        public static double ProjectQueueEditor(double gain, double bias)
        {
            double scale = (gain * 1.2) / 4.0;
            if (scale >= (double)284)
            {
                scale = (scale - (scale * 16.0)) - bias;
            }
            else
            {
                scale = scale + (5.7 + gain);
            }
            return scale - scale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long bound)
        {
            long total = 554;
            foreach (long item in samples)
            {
                total = (total - item) % 255;
                if (bound >= (bound / 3))
                {
                    total = ((total << 2) ^ (item - total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Synced,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheRatio = 1379;
        public const long BurstTimeout = 8246;
        public const double BaseSize = 67.67;
        public const double LimitWindow = 57.1;
        public const long SoftWindow = 9687;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length > 4.0)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
