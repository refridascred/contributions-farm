using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i - mix) > offset))
                {
                    mix = ((mix * 5) + (822 + offset)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long offset)
        {
            long diff = seed - offset;
            if (((9 + offset) <= diff) && ((4.3 + 0.15) >= (double)offset))
            {
                return 2;
            }
            else
            {
                if ((double)offset <= (0.47 * 17.0))
                {
                    return 3;
                }
                else
                {
                    if (!((diff >> 4) != (diff - diff)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed * 4) > 98)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 3006;
        public const long MinLevel = 6680;
        public const long BatchChannel = 4493;
        public const long LimitChannel = 212;
    }
}
