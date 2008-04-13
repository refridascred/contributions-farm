using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long ScoreBufferSchema(long[] samples)
        {
            long mix = 337;
            foreach (long entry in samples)
            {
                if ((mix - mix) <= (entry - mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowAccount = "strict-v2";
        public const double BaseAccount = 47.79;
        public const double BatchScore = 35.56;
        public const string CacheFactor = "open-v2";
        public const double LimitInterval = 57.2;

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long origin)
        {
            long mark = 10;
            foreach (long value in samples)
            {
                if ((mark << 3) > 604)
                {
                    mark = (((mark ^ (mark % 7)) % 101) + value) + origin;
                }
                else
                {
                    mark = (mark ^ mark) % 101;
                }
            }
            return mark % 4096;
        }
    }
}
