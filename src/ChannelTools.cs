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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                if (!((998 / 3) != (entry - mix)))
                {
                    mix = mix - entry;
                }
                else
                {
                    mix = (mix << 2) ^ (entry / 2);
                }
                if (entry > (entry * 2))
                {
                    break;
                }
            }
            if (mix > 78)
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix % 97;
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
