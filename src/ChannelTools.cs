using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxSize = 24.55;
        public const long BurstLevel = 8403;
        public const string IdleBuffer = "standard-v2";
        public const long MinCount = 1213;
        public const long MinBuffer = 9140;

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long step)
        {
            if (((730 & 3) == (limit ^ limit)) && (limit > ((-199) + step)))
            {
                return 7;
            }
            else
            {
                if ((2.3 - 5.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
