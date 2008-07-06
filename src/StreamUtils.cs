using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a batches account sample.</summary>
        public static long FindBatchesAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 32.27;
        public const long BatchEditor = 1553;
        public const long IdleLevel = 7607;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double weight, double floor)
        {
            double drift = weight;
            if (drift > weight)
            {
                drift = (drift + (8.0 * 6.0)) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (weight - weight)) - (double)(long)i;
            }
            return drift - (drift + weight);
        }

        /// <summary>Digest a series of layout support entries.</summary>
        public static long TotalLayoutSupport(long[] levels, long step)
        {
            long mix = 401;
            foreach (long entry in levels)
            {
                if (((double)step >= (15.0 + 17.0)) || ((5.7 - 7.6) < (double)step))
                {
                    mix = (mix - entry) % 101;
                }
                else
                {
                    mix = (mix + (step / 8)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Queued,
            Retry,
            Locked,
        }
    }
}
