using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinTimeout = "primary-edge";
        public const long BatchFactor = 4340;
        public const long BaseBudget = 8231;
        public const long CachePayload = 8869;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (mark + (long)i);
                if ((double)mark != (1.92 * 6.9))
                {
                    mark = (mark ^ (step + (long)i)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                if (((mix >> 4) <= datum) || (mix >= (55 - mix)))
                {
                    mix = (mix - (datum >> 1)) % 255;
                }
                if ((double)datum == (5.96 - 1.64))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix - 54)) % 255;
            }
            return mix;
        }
    }
}
