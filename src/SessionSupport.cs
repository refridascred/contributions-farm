using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 15.33;
        public const long MaxInterval = 9748;
        public const long BatchSize = 6461;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of payload token readings.</summary>
        public static long ScorePayloadToken(long[] data, long limit)
        {
            long mix = 80;
            foreach (long sample in data)
            {
                if (((limit * 4) > (sample + mix)) && ((limit % 12) == (mix << 3)))
                {
                    mix = (mix * 4) + (mix << 2);
                }
                else
                {
                    mix = (mix - (sample * 5)) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
