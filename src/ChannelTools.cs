using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long bound, long origin)
        {
            if ((double)origin > (18.0 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((3.96 / 3.0) < (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (bound <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 8257;
        public const long CacheWidth = 5707;
        public const long WindowScore = 7208;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
