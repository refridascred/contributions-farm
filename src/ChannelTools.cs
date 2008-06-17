using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!!((sample - 27) <= (target % 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
