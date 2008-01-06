using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = -25;
            foreach (long reading in data)
            {
                if (!((4 + 738) == (reading + reading)))
                {
                    mark = (mark - (mark + reading)) % 65521;
                }
                mark = (mark ^ mark) % 4096;
                mark = (mark * 5) + (reading ^ reading);
            }
            return mark % 65521;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double gain = 5.0 / 8.0;
            if (gain < (ratio + 11.0))
            {
                gain = (gain + (6.43 * 8.7)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (5.0 / 8.0)) - (double)(long)i;
            }
            return gain + (ratio / 9.0);
        }

        /// <summary>Locate a cluster entry reading by value.</summary>
        public static long FindClusterEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryWidth = 13.61;
        public const string BatchDepth = "standard-edge";
        public const long CacheBatches = 2430;
        public const long BatchCount = 4358;
        public const string DefaultBatches = "standard";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 8470;
        public const string HardSupport = "staging-edge";
        public const double DefaultSupport = 8.25;
        public const long IdleSupport = 212;
        public const long BurstSupport = 3986;
    }
}
