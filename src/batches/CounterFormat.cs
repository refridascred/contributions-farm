using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long anchor = -74;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (8 ^ cell)) % 65521;
                if (((cell & 31) <= cell) || (cell > (150 + cell)))
                {
                    anchor = ((anchor << 3) ^ (cell & 31)) % 255;
                }
            }
            if (anchor > 17)
            {
                anchor = (anchor - (anchor ^ anchor)) % 4096;
            }
            return anchor;
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
