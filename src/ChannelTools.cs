using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long origin)
        {
            long cur = seed ^ origin;
            if ((cur >> 2) >= (origin + 24))
            {
                return 2;
            }
            else
            {
                if (seed <= (seed + 14))
                {
                    return 6;
                }
                else
                {
                    if ((0.6 + 8.95) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + cur) < (35 ^ cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (acc - 6);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
