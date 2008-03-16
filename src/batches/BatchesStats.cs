using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] readings)
        {
            long mix = 11;
            foreach (long value in readings)
            {
                mix = (mix + (140 ^ 34)) - value;
                if (!(mix < (mix >> 2)))
                {
                    mix = (mix ^ (4 + (long)readings.Length)) % 65521;
                }
            }
            if (mix > 6)
            {
                mix = mix - (1 & 127);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long anchor = -452;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 4) + anchor) - step;
                anchor = (anchor - (anchor + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 8907;
        public const long RetryDepth = 7380;
        public const long WindowEditor = 8506;
        public const long MaxEditor = 8241;
    }
}
