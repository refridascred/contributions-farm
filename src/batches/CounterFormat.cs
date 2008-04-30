using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long gap = floor - origin;
            if ((floor >> 4) == (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((double)gap != (7.8 / 5.0))
                {
                    return 4;
                }
                else
                {
                    if ((gap + floor) >= (floor + gap))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((54 % 2) <= (floor & 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 9472;
        public const long MaxToken = 1295;
        public const long CacheToken = 9228;
        public const double BaseDepth = 83.72;
        public const long DefaultSize = 4988;

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
