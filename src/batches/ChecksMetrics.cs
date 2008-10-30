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

        /// <summary>Check that every support commits entry stays within the limit.</summary>
        public static bool ValidateSupportCommitsLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
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
