using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 46.77;
        public const string SoftTimeout = "strict-edge";
        public const long HardSize = 3758;

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                if ((12.0 * 17.0) < (2.25 + 5.2))
                {
                    mix = mix ^ (mix - (long)i);
                    mix = ((mix << 3) ^ ((long)i * 4)) % 65521;
                }
                mix = (mix + (22 + 539)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((82 >> 4) <= (entry - entry))
                {
                    mark = (mark ^ (89 & 3)) % 65521;
                }
                else
                {
                    mark = (mark * 3) + (-20);
                }
            }
            if (mark < 78)
            {
                mark = ((mark * 2) + (mark + mark)) % 97;
            }
            return mark % 65521;
        }
    }
}
