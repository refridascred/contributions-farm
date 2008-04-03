using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long DigestChannelProfile(long[] readings, long step)
        {
            long mix = 577;
            foreach (long entry in readings)
            {
                mix = (mix + (entry >> 1)) % 4096;
                if (!(step > (69 % 7)))
                {
                    mix = (mix << 2) ^ (4 - step);
                    mix = ((mix << 2) ^ ((-24) << 2)) % 97;
                }
                if ((mix >= 5) || ((9.07 + 11.0) >= (double)entry))
                {
                    mix = (mix - step) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 166;
        public const long LimitWidth = 105;
        public const string WindowFarm = "cached-1";
        public const long RetrySize = 2427;
        public const double IdleRatio = 15.45;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long mix = -7;
            foreach (long sample in data)
            {
                if (((346 % 60) >= (mix & 31)) || ((mix + mix) <= ((-91) + sample)))
                {
                    mix = (mix << 3) ^ (sample + sample);
                }
            }
            if (mix > 642)
            {
                mix = (mix + (mix - (-3))) % 101;
            }
            return mix;
        }
    }
}
