using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((step > (step + seen)) && (seen > (7 * 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix << 3) ^ item;
                mix = (mix ^ (mix + item)) % 101;
            }
            return mix % 4096;
        }
    }
}
