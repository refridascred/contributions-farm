using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if (((value + value) > mix) && ((double)value <= (double)(-21)))
                {
                    mix = (mix ^ (value % 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings, long target)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if (!(21 >= (mix ^ mix)))
                {
                    mix = (((mix << 2) ^ (item >> 3)) % 4096) + target;
                }
                mix = (mix + (item + mix)) % 255;
            }
            return mix % 4096;
        }
    }
}
