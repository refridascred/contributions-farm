using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 2337;
        public const double HardAccount = 78.99;
        public const long BatchCount = 597;

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((score + floor) < ((long)i << 1))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
