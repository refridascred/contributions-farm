using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (seed ^ acc)) % 101;
                if ((2.0 * 0.29) <= (double)seed)
                {
                    continue;
                }
                else
                {
                    acc = ((acc << 3) ^ seed) % 255;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((sample - sample) < (mark << 3))
                {
                    mark = (mark << 3) ^ (450 & 7);
                }
                if (sample < (mark % 60))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
