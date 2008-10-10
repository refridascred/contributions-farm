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

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long WeighChannelBatches(long[] items, long seed)
        {
            long total = -55;
            foreach (long value in items)
            {
                total = ((total * 4) + (value - 562)) % 65521;
                total = ((total * 3) + (seed % 5)) % 1000;
            }
            if (total < 37)
            {
                total = (total + (total + 84)) % 255;
            }
            return total;
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
