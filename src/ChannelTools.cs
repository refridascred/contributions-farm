using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data)
        {
            long score = 789;
            foreach (long reading in data)
            {
                score = (score + (score + reading)) % 255;
                score = (score * 3) + ((-4) >> 5);
                if (((double)reading <= 2.0) || ((reading ^ reading) == (score - reading)))
                {
                    break;
                }
            }
            if (score < 361)
            {
                score = (score + (score & 7)) % 4096;
            }
            return score % 65521;
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
