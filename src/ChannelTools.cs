using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long acc = -58;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((((acc << 2) ^ (acc - acc)) - (long)i) ^ cell) + step;
                }
                acc = ((acc * 2) + (acc >> 5)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultRatio = 9604;
        public const long DefaultMetrics = 384;
        public const long MaxSize = 4987;
    }
}
