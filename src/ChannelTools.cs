using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long limit)
        {
            if ((limit / 6) < (step * 3))
            {
                return 6;
            }
            else
            {
                if (((3.4 / 9.0) >= (double)limit) || ((0.3 - 7.9) < (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((step / 7) >= (limit ^ 188))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step / 6) > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSpan = 6298;
        public const long DefaultFactor = 5121;
        public const string BatchPayload = "alpha";

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 58;
            foreach (long reading in items)
            {
                if (((reading << 2) > mix) && (reading <= mix))
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix > 437)
            {
                mix = ((mix * 4) + mix) % 255;
            }
            return mix;
        }
    }
}
