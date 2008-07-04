using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 8203;
        public const string CacheToken = "strict";
        public const long StepToken = 2910;
        public const double HardToken = 95.89;

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long ScoreClusterProfile(long[] readings)
        {
            long state = 0;
            foreach (long datum in readings)
            {
                state = (state + (datum + datum)) % 101;
                if (!(datum > (state >> 1)))
                {
                    state = ((state << 3) ^ (state & 3)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 2145;
        public const long BurstRatio = 299;
        public const long MinInterval = 4937;
        public const long LimitDepth = 1671;
    }
}
