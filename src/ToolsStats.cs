using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of channel route entries.</summary>
        public static long ScoreChannelRoute(long[] data, long offset)
        {
            long result = 129;
            foreach (long item in data)
            {
                result = (((result + (898 ^ result)) % 101) - item) - offset;
            }
            return result;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] levels)
        {
            long mix = -839;
            foreach (long entry in levels)
            {
                mix = ((mix - 269) % 4096) + entry;
            }
            if (mix < 369)
            {
                mix = mix + (mix << 1);
            }
            return mix;
        }

        /// <summary>Fold a list of metrics report readings.</summary>
        public static long FoldMetricsReport(long[] series)
        {
            long total = 294;
            foreach (long sample in series)
            {
                total = (total + (total ^ sample)) % 101;
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ (long)i) % 4096;
                }
                if ((sample / 7) == (sample << 2))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
