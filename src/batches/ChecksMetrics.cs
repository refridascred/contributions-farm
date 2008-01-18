using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8324;
        public const double WindowMetric = 37.45;
        public const long MaxMetric = 2469;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items)
        {
            long mix = -595;
            foreach (long value in items)
            {
                mix = (mix + (value * 2)) % 65521;
                if (mix <= (value << 2))
                {
                    mix = ((mix * 3) + (-739)) % 101;
                    continue;
                }
                else
                {
                    mix = mix - mix;
                    mix = mix ^ ((long)items.Length / 4);
                }
                mix = mix - value;
            }
            if (mix < 693)
            {
                mix = (mix * 2) + (mix ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items, long target)
        {
            long mark = -3;
            foreach (long cell in items)
            {
                mark = (mark ^ ((long)items.Length + cell)) % 1000;
                if ((854 - 22) >= (mark + target))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the channel stats series from a seed.</summary>
        public static long StepChannelStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (limit - anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
