using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleInterval = 7887;
        public const long SoftBatch = 601;
        public const long MaxLevel = 6855;
        public const double LimitBudget = 72.89;

        /// <summary>Digest a series of notes stream entries.</summary>
        public static long WeighNotesStream(long[] series)
        {
            long mix = 628;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix - (sample >> 5)) % 255;
                    mix = (mix + ((long)i + sample)) % 101;
                }
                if ((sample & 255) > (25 & 15))
                {
                    mix = (mix << 3) ^ (mix ^ (-5));
                }
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
