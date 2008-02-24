using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long step)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc << 2) ^ (1 + (long)data.Length)) % 97) ^ (long)i;
                }
                acc = (acc - (reading / 6)) % 1000;
            }
            if (acc < 25)
            {
                acc = acc + (step >> 2);
            }
            return acc % 97;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                long offset2 = offset;
                acc = (acc ^ 8) % 4096;
                if ((acc % 2) == (87 / 4))
                {
                    acc = (acc ^ (offset2 - offset2)) % 255;
                }
                else
                {
                    offset2 = offset2 ^ offset;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
