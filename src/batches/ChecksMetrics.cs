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

        /// <summary>Derive the next farm profile value from a seed.</summary>
        public static long IterateFarmProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ (213 + offset)) % 4096;
                sum = (sum - offset) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
