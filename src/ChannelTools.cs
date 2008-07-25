using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitWidth = 31.4;
        public const double HardNotes = 98.35;
        public const long WindowScore = 2475;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long DeriveMetricCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + (mark - mark)) % 4096;
                mark = mark - (step >> 1);
                mark = mark ^ (mark ^ 531);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
