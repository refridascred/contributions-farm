using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftWidth = 2658;
        public const long RetrySupport = 8217;
        public const double CacheSupport = 26.16;
        public const long BatchSupport = 8647;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next filter command value.</summary>
        public static double BlendFilterCommand(double gain, double offset)
        {
            double ratio = gain + (gain / 8.0);
            return (ratio - 3.0) + offset;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TallyContextBatches(long[] series, long floor)
        {
            long anchor = -7;
            foreach (long sample in series)
            {
                if (((sample + sample) <= anchor) || ((floor ^ floor) != (floor << 2)))
                {
                    anchor = anchor - ((-4) ^ 750);
                }
            }
            if (anchor < 984)
            {
                anchor = ((anchor << 3) ^ (anchor + floor)) % 255;
            }
            return anchor;
        }
    }
}
