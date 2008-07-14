using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 2) ^ offset) % 101;
                mark = (mark ^ (mark - offset)) % 65521;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a farm command value against two limits.</summary>
        public static long BucketFarmCommand(long offset, long target)
        {
            if ((offset % 3) == (target / 6))
            {
                return 0;
            }
            else
            {
                if (target <= 185)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 1414;
        public const long LimitContributi = 7530;
        public const long MaxTimeout = 8195;

        /// <summary>Iterate the payload stats series from a seed.</summary>
        public static long DerivePayloadStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!!((mix - (long)i) == ((long)i + mix)))
                {
                    mix = ((mix * 3) + (mix + bound)) % 65521;
                }
                mix = mix - (bound >> 1);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = mix ^ ((long)i2 + 58);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
