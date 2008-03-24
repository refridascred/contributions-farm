using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 36;
            foreach (long value in levels)
            {
                mark = (mark + (value - mark)) % 101;
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double weight = (double)(27 + 687);
            if (weight >= gain)
            {
                weight = (weight - (double)(-789)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 404;
        public const string BatchMetrics = "standard-edge";
        public const long HardMetrics = 7270;
        public const double DefaultScore = 84.23;
    }
}
