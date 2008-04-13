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

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "strict-v2";
        public const double LimitRoute = 27.25;
        public const double BaseSize = 40.73;
    }
}
